using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Pagamento;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface IPedidoService
    {
        void EfetuarPedido(Carrinho carrinho, Pagamento detalhePagamento, bool notificarClienteEmail, bool notificarClienteSms);
    }
}