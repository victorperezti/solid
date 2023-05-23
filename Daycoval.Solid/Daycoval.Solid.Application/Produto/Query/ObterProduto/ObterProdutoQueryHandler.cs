using AutoMapper;
using Daycoval.Solid.Domain.Services.Interfaces;
using MediatR;

namespace Daycoval.Solid.Application.Produto.Query.ObterProduto;

public class ObterProdutoQueryHandler : IRequestHandler<ObterProdutoQuery, ObterProdutoViewModel>
{
    private readonly IProdutoService _produtoRepository;
    private readonly IMapper _mapper;

    public ObterProdutoQueryHandler(IProdutoService produtoRepository, IMapper mapper)
    {
        _produtoRepository = produtoRepository;
        _mapper = mapper;
    }

    public Task<ObterProdutoViewModel> Handle(ObterProdutoQuery request, CancellationToken cancellationToken)
    {
        var produto = _produtoRepository.Obter(request.Id);
        var produtoViewModel = _mapper.Map<ObterProdutoViewModel>(produto);

        return Task.FromResult(produtoViewModel);
    }
}