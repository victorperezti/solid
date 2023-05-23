using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Produto;
using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface IEstoqueService
    {
        void SolicitarProduto(List<Produto> produto);

        void BaixarEstoque(List<Produto> produto);

        void ProcessarPedido(Carrinho carrinho);
    }
}