using PMT_backend.Services.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMT_backend.Services.EmailService
{
    public interface IEmailService
    {
        void SendEmail(Message message);
    }
}
