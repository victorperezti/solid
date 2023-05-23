using Daycoval.Solid.Domain.Entities.Produto;
using System;

namespace Daycoval.Solid.Domain.Services.Interfaces
{
    public interface IProdutoService
    {
        Produto Obter(Guid id);
    }
}