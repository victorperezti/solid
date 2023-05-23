using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Documento
    {
        public Documento(string numero, ETipoDocumento tipoDocumento)
        {
            Numero = numero;
            TipoDocumento = tipoDocumento;
        }

        public string Numero { get; private set; }
        public ETipoDocumento TipoDocumento { get; private set; }

        /// <summary>
        /// Validar se é CPF ou CNPJ com as repectivas regras
        /// </summary>
        /// <returns></returns>
        private bool Validate()
        {
            if (TipoDocumento == ETipoDocumento.CNPJ && Numero.Length == 14)
                return true;

            if (TipoDocumento == ETipoDocumento.CPF && Numero.Length == 11)
                return true;

            return false;
        }
    }
}
