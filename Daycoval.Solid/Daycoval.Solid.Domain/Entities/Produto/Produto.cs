using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.Produto
{
    public abstract class Produto : Entity
    {
        protected Produto(string descricao, decimal valor, int quantidade, ETipoProduto tipoProduto)
        {
            Descricao = descricao;
            Valor = valor;
            Quantidade = quantidade;
            TipoProduto = tipoProduto;
        }

        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public int Quantidade { get; set; }
        public ETipoProduto TipoProduto { get; set; }

        public abstract decimal CalcularValorImposto();

    }
}