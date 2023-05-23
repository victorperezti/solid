using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Telefone
    {
        public Telefone(string celular, ETipoTelefone tipoTelefone)
        {
            Numero = celular;
            TipoTelefone = tipoTelefone;
        }

        public string Numero { get; private set; }
        public ETipoTelefone TipoTelefone { get; private set; }
    }
}
