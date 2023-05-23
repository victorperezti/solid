using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Telefone
    {
        public Telefone(string numero, ETipoTelefone tipoTelefone)
        {
            Numero = numero;
            TipoTelefone = tipoTelefone;
        }

        public string Numero { get; private set; }
        public ETipoTelefone TipoTelefone { get; private set; }
    }
}