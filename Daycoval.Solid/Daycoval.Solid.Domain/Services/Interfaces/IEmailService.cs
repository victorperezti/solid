using Daycoval.Solid.Domain.Entities.DomainObject;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface IEmailService
    {
        void EnviarEmail(string from, string to, string subject, string body);
    }
}
