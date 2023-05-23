using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.Produto
{
    public class ProdutoSuperfluo : Produto
    {
        public ProdutoSuperfluo(string descricao, decimal valor, int quantidade, ETipoProduto tipoProduto)
            : base(descricao, valor, quantidade, tipoProduto) { }

        public override decimal CalcularValorImposto()
        {
            // Lógica de cálculo de imposto para produtos supérfluos
            // Retorna o valor do imposto calculado
            decimal valorImposto = 0;

            return valorImposto;
        }
    }
}
