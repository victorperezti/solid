using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Produto;
using Daycoval.Solid.Domain.Services.Interfaces;
using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Services
{
    public class EstoqueService : IEstoqueService
    {
        public void ProcessarPedido(Carrinho carrinho)
        {
            //Este método não precisa ser implementado.
        }

        public void SolicitarProduto(List<Produto> produto)
        {
            //Este método não precisa ser implementado.
        }

        public void BaixarEstoque(List<Produto> produto)
        {
            //Este método não precisa ser implementado.
        }
    }
}