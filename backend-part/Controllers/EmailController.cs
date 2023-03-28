using backend_part.Models;
using backend_part.Services.EmailService;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using static Org.BouncyCastle.Math.EC.ECCurve;

namespace backend_part.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }
        [HttpPost]
        public IActionResult SendEmail(EmailDto request)
        {
            _emailService.SendEmail(request);

            return Ok("Email Send Successfull.");
        }

        /* private readonly IConfiguration _config;

         public EmailController(IConfiguration config)
         {
             _config = config;
         }

         [HttpPost]
         public IActionResult SendEmail(EmailDto request)
         {
             var email = new MimeMessage();
             email.From.Add(MailboxAddress.Parse(_config.GetSection("EmailUsername").Value));
             email.To.Add(MailboxAddress.Parse(request.To));
             email.Subject = request.Subject;
             email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

             using var smtp = new SmtpClient();
             smtp.Connect(_config.GetSection("EmailHost").Value, 587, SecureSocketOptions.StartTls);
             smtp.Authenticate(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value);
             smtp.Send(email);
             smtp.Disconnect(true);

             return Ok("Email Send Successfull.");
         }*/
    }
}
