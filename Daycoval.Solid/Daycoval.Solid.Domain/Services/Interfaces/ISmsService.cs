using Daycoval.Solid.Domain.Entities.DomainObject;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface ISmsService
    {
        void EnviarSms(Telefone celular, string mensagem);
    }
}
