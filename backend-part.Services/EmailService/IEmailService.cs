using backend_part.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend_part.Services.EmailService
{
    public interface IEmailService
    {
        public void SendEmail(EmailDto request);
    }
}
