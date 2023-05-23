using Daycoval.Solid.Domain.Services.Interfaces;
using System.Net.Mail;

namespace Daycoval.Solid.Domain.Services
{
    public class EmailService : IEmailService
    {
        public void EnviarEmail(string from, string to, string subject, string body)
        {
            using (var msg = new MailMessage(from, to))
            using (var smtp = new SmtpClient("servidor.smtp")) //todo:arquivo configuração
            {
                msg.Subject = subject;
                msg.Body = body;

                smtp.Send(msg);
            }
        }
    }
}