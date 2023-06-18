using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.JsonWebTokens;
using Microsoft.IdentityModel.Tokens;
using PMT_backend.Models;
using PMT_backend.Services.EmailService;
using PMT_backend.Services.Model;
using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Numerics;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace PMT_backend.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IEmailService _emailService;
        private readonly IConfiguration _configuration;

        public UserController(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager, IConfiguration configuration, IEmailService emailService)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailService = emailService;
            _configuration= configuration;
        }


        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegisterUser registerUser)
        {
            //check user exit
            var userExit = await _userManager.FindByEmailAsync(registerUser.Email);
            if (userExit != null)
            {
                return Ok("User alredy exit.");
            };
            //add to the database
            IdentityUser user = new()
            {
                UserName = registerUser.UserName,
                Email = registerUser.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                PhoneNumber = registerUser.PhoneNumber
            };
            var result = await _userManager.CreateAsync(user, registerUser.Password);
            if (!result.Succeeded)
            {
                return Ok("User failed to create.");

            }
            else
            {
                var token = await _userManager.GenerateEmailConfirmationTokenAsync(user);
                var confirmationLink = Url.Action(nameof(ConfirmEmail), "User", new { token, email = user.Email }, Request.Scheme);
                var htmlBody = $@"
                                  <html>
<body style=""font-family: Arial, sans-serif;"">
    <div style=""border-style: dotted; border-color: #ccc; margin: 50px auto; max-width: 500px; padding: 20px;"">
        <h2 style=""color: #333;"">Welcome to PM_Tool!</h2>
        <p style=""margin-top: 20px;"">Hello,</p>
        <p>Thank you for signing up for PM_Tool! To get started, please confirm your email address by clicking the button below:</p>
        <div style=""text-align: center; margin-top: 30px;"">
            <a href=""{confirmationLink}"" style=""background-color: #4CAF50; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;"">Confirm Email</a>
        </div>
        <p style=""margin-top: 30px;"">If the button above doesn't work, you can also copy and paste the following link into your web browser:</p>
        <p style=""word-break: break-all; background-color: #f5f5f5; padding: 10px; border-radius: 5px;"">{confirmationLink}</p>
        <p style=""margin-top: 20px;"">Please note that you must confirm your email within 24 hours to activate your account.</p>
        <p>If you didn't create an account on PM_Tool, you can safely ignore this email.</p>
        <p>If you have any questions or need further assistance, please don't hesitate to contact our support team.</p>
        <p style=""margin-top: 20px;"">Best regards,<br/>The PM_Tool Team</p>
    </div>
</body>
</html>";
                var message = new Message(new string[] { user.Email! }, "Confiremation email Link", htmlBody);
                _emailService.SendEmail(message);

                return Ok("User created & Email send successfull..!");
            }
        }

        [HttpGet("ConfirmEmail")]
        public async Task<IActionResult> ConfirmEmail(string token, string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user != null)
            {
                var result = await _userManager.ConfirmEmailAsync(user, token);
                if (result.Succeeded)
                {
                    return Redirect("http://localhost:3000"); 
                    /*return Ok("Email Verified successfull");*/
                }
            }
            return Ok("This user Doesnot exit");
        }


        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUser loginUser)
        {
            var user = await _userManager.FindByEmailAsync(loginUser.Email);
            if (user != null && await _userManager.CheckPasswordAsync(user, loginUser.Password))
            {
                if (!await _userManager.IsEmailConfirmedAsync(user))
                {
                    return BadRequest("Email not verified. Please verify your email before logging in.");
                }

                var authClaim = new List<Claim>
        {
            new Claim("Email", user.Email),
            new Claim("Id", user.Id),
            new Claim("UserName", user.UserName),
            new Claim(System.IdentityModel.Tokens.Jwt.JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
        };

                var jwtToken = GetToken(authClaim);
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(jwtToken),
                    expiration = jwtToken.ValidTo
                });
            }

            return Unauthorized();
        }

        [HttpPost]
        [AllowAnonymous]
        [Route("forgot-password")]
        public async Task<IActionResult> ForgotPassword([Required] string email)
        {
            var user = await _userManager.FindByEmailAsync (email);
            if(user != null)
            {
                var token = await _userManager.GeneratePasswordResetTokenAsync(user);
                var forgotPasswordLink = Url.Action(nameof(ResetPassword), "User", new { token, email=user.Email }, Request.Scheme);
                var htmlBody = $@"
                                  <html>
<body style=""font-family: Arial, sans-serif;"">
    <div style=""border-style: dotted; border-color: #ccc; margin: 50px auto; max-width: 500px; padding: 20px;"">
        <h2 style=""color: #333;"">Reset Your Password</h2>
        <p style=""margin-top: 20px;"">Hello,</p>
        <p>We received a request to reset your password for your PM_Tool account. If you didn't make this request, you can safely ignore this email.</p>
        <p style=""margin-top: 20px;"">To reset your password, please click the button below:</p>
        <div style=""text-align: center; margin-top: 30px;"">
            <a href=""{forgotPasswordLink}"" style=""background-color: #4CAF50; color: white; padding: 10px 20px; text-decoration: none; border-radius: 5px;"">Reset Password</a>
        </div>
        <h3 style=""margin-top: 30px;"">First copy Password Reset Token and then click Reset Password buttom</h3>
        <h3>Password Reset Token: </h3>
        <p style=""word-break: break-all; background-color: #f5f5f5; padding: 10px; border-radius: 5px;"">{token}</p>
        <p style=""margin-top: 20px;"">Please note that this link is valid for 24 hours. After that, you'll need to initiate the reset password process again.</p>
        <p>If you have any questions or need further assistance, please don't hesitate to contact our support team.</p>
        <p style=""margin-top: 20px;"">Best regards,<br/>The PM_Tool Team</p>
    </div>
</body>
</html>";
                var message = new Message(new string[] { user.Email! }, "forgot Password email Link", htmlBody);
                _emailService.SendEmail(message);
                return Ok("Forgot password Email send successfull..!");
            }
            return Ok("Cound not Sent link to email. Please try again...");
        }

        [HttpGet("reset-password")]
        public async Task<IActionResult> ResetPassword(string token ,string email)
        {
            var model = new ResetPassword { Token= token,Email = email  };
            return Redirect("http://localhost:3000/forgotPassword");

        }

        [HttpPost]
        [AllowAnonymous]
        [Route("reset-password")]
        public async Task<IActionResult> ResetPassword(ResetPassword resetPassword)
        {
            var user = await _userManager.FindByEmailAsync(resetPassword.Email);
            if (user != null)
            {
                var resetPassResult = await _userManager.ResetPasswordAsync(user, resetPassword.Token, resetPassword.Password);
                if (!resetPassResult.Succeeded)
                {
                    foreach (var error in resetPassResult.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                    return Ok(ModelState);
                }
                return Ok("Password Change successfull..!");
            }
            return Ok("Cound not Sent link to email. Please try again...");
        }


        private JwtSecurityToken GetToken(List<Claim> authClaims){
        var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Secret"]));

            var token = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                expires: DateTime.Now.AddHours(1),
                claims: authClaims,
                signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                );
            return token;
        }

       
        [HttpGet]
        public async Task<ActionResult<List<UserDto>>> GetAllUserNamesAndIds()
        {
            var users = await _userManager.Users.Where(u => u.EmailConfirmed).ToListAsync();

            if (users == null || users.Count == 0)
            {
                return NotFound("No users found.");
            }

            var userDtoList = users.Select(u => new UserDto { UserName = u.UserName, Id = u.Id }).ToList();

            return Ok(userDtoList);
        }




    }
}
