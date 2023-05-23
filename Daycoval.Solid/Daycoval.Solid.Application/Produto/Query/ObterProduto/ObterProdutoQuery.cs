using MediatR;

namespace Daycoval.Solid.Application.Produto.Query.ObterProduto
{
    public class ObterProdutoQuery : IRequest<ObterProdutoViewModel>
    {
        public Guid Id { get; set; }
    }
}