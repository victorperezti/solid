using MediatR;

namespace Daycoval.Solid.Application.Produto.Command.RegistrarProduto;

public class RegistrarProdutoCommand : IRequest<bool>
{
    public string? Descricao { get; set; }
    public decimal Valor { get; set; }
    public int Quantidade { get; set; }
}