using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Pagamento;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface IPagamentoService
    {
        void EfetuarPagamento(Carrinho carrinho, Pagamento pagamento);
    }
}
