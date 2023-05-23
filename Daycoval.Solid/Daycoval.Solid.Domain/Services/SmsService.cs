using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Services.Interfaces;

namespace Daycoval.Solid.Domain.Services
{
    public class SmsService : ISmsService
    {
        public void EnviarSms(Telefone celular, string mensagem)
        {
            //Este método não precisa ser implementado.
            throw new System.NotImplementedException();
        }
    }
}