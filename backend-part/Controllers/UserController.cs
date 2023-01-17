using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data;
using System.Security.Cryptography;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly DataContext _context;
        public UserController(DataContext context) 
        {
            _context = context;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(UserRegister request)
        {
            if(_context.Users.Any(u => u.Email == request.Email)) 
            {
                return BadRequest("User alredy exists");
            }
            CreatedPasswordHash(request.Password, 
                out byte[] passwordHash, 
                out byte[] passwordSalt);

            var User = new User
            {
                Email = request.Email,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                VerificationToken = CreateRandomToken()
            };
            _context.Users.Add(User);
            await _context.SaveChangesAsync();

            return Ok("User Sucessful Registered!");
        }

        [HttpPost("Login")]
        public async Task<IActionResult> Login(UserLogin request)
        {
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == request.Email);
            if (user == null)
            {
                return BadRequest("User not found!");
            }
            if (!VerifyPasswordHash(request.Password, user.PasswordHash, user.PasswordSalt))
            {
                return BadRequest("Password is incorrect.");
            }
            if (user.VerifiedAt == null) 
            {
                return BadRequest("Not Verified!");
            }
            return Ok($"Welcome back, {user.Email}!");
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
            CreatedPasswordHash(request.Password,
                out byte[] passwordHash,
                out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            user.PasswordResetToken = null;
            user.ResetTokenExpires = null;

            await _context.SaveChangesAsync();

            return Ok("Password successfully reset.");
        }

        private void CreatedPasswordHash(string password, out byte[] passwordHash,out byte[] passwordSalt)
        {
            using(var hmas = new HMACSHA512()) 
            {
                passwordSalt = hmas.Key;
                passwordHash = hmas
                    .ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

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
    }
}
