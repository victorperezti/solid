using Daycoval.Solid.Domain.Entities.Enums;

namespace Daycoval.Solid.Domain.Entities.Produto
{
    public class ProdutoAlimento : Produto
    {
        public ProdutoAlimento(string descricao, decimal valor, int quantidade)
            : base(descricao, valor, quantidade)
        {
        }

        public override decimal CalcularValorImposto()
        {
            // Lógica de cálculo de imposto para produtos alimentícios
            // Retorna o valor do imposto calculado
            decimal valorImposto = 0.05M * Valor;

            return valorImposto;
        }
    }
}