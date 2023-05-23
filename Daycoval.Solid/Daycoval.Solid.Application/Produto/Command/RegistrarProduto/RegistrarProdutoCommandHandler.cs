using Daycoval.Solid.Domain.Services.Interfaces;
using Daycoval.Solid.Infrastructure.UoW;
using MediatR;

namespace Daycoval.Solid.Application.Produto.Command.RegistrarProduto;

public class RegistrarProdutoCommandHandler : CommandHandler, IRequestHandler<RegistrarProdutoCommand, bool>
{
    private readonly IProdutoService _produtoService;

    public RegistrarProdutoCommandHandler(IUnitOfWork uow, IMediator mediator, IProdutoService produtoService) : base(uow, mediator)
    {
        _produtoService = produtoService;
    }

    public Task<bool> Handle(RegistrarProdutoCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}