using backend_part.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Org.BouncyCastle.Crypto.Generators;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        private readonly IConfiguration _configuration;

        public UserController(DataContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            if(_context.Users.Any(u => u.Email == request.Email)) 
            {
                return BadRequest("User alredy exists");
            }
            /*CreatedPasswordHash(request.Password, 
                out byte[] passwordHash, 
                out byte[] passwordSalt);*/
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            var User = new User
            {

                Name = request.Name,
                Email = request.Email,
                PasswordHash = passwordHash,
                PhoneNo =request.PhoneNo,
                VerificationToken = CreateRandomToken()
            };
            var token = CreateRandomToken(User);
            /*var confirmationLink = Url.Action(nameof(ConfirmEmail), "Authentication",
               new { token, email = User.Email }, Request.Scheme);*/
            _context.Users.Add(User);
            await _context.SaveChangesAsync();;

            return Ok(token);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return BadRequest("User not found!");
            }
            if (!BCrypt.Net.BCrypt.Verify(request.Password, user.PasswordHash))
            {
                return BadRequest("Password is incorrect.");
            }
            if (user.VerifiedAt == null)
            {
                return BadRequest("Not Verified!");
            }
            string token = CreateRandomToken(user);
            return Ok(token);
        }

        [HttpPost("verify")]
        public async Task<IActionResult> Verify(string token)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.VerificationToken == token);
            if (user == null)
            {
                return BadRequest("Invalid Token.");
            }
            user.VerifiedAt = DateTime.Now;
            await _context.SaveChangesAsync();
            return Ok("User Verified!");
        }

        [HttpPost("forgot-password")]
        public async Task<IActionResult> forgotPassword(string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                return BadRequest("User not found.");
            }
            user.PasswordResetToken = CreateRandomToken();
            user.ResetTokenExpires = DateTime.Now.AddMinutes(5);
            await _context.SaveChangesAsync();

            return Ok("You may now reset your password.");
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPassword request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.PasswordResetToken == request.Token);
            if (user == null || user.ResetTokenExpires < DateTime.Now)
            {
                return BadRequest("Invalid Token.");
            }
            /*CreatedPasswordHash(request.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);*/
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
            user.PasswordHash = passwordHash;
            user.PasswordResetToken = null;
            user.ResetTokenExpires = null;

            await _context.SaveChangesAsync();

            return Ok("Password successfully reset.");
        }

        /*[HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return Ok("Email Verified successfull");
                }
            }
            return Ok("This user Doesnot exit");
        }*/

        /*private void CreatedPasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using(var hmas = new HMACSHA512()) 
            {
                passwordSalt = hmas.Key;
                passwordHash = hmas
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }*/

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmas = new HMACSHA512(passwordSalt))
            {
                var computedHash = hmas
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string CreateRandomToken()
        {
            return Convert.ToHexString(RandomNumberGenerator.GetBytes(64));
        }

        private string CreateRandomToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email)
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value!));

            var cred = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);
            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddDays(1),
                signingCredentials: cred
                );
            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }


    }
}
