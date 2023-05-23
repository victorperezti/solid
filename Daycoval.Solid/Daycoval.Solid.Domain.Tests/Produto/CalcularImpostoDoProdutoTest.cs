using Daycoval.Solid.Domain.Entities.Produto;

namespace Daycoval.Solid.Domain.Tests.Produto
{
    public class CalcularImpostoDoProdutoTest
    {
        [Theory]
        [InlineData("Arroz", 10.99, 2, 0.5495)]
        [InlineData("Feijão", 7.50, 4, 0.375)]
        public void CalcularValorImpostoDoProdutoAlimento(string nome, decimal valor, int quantidade, decimal valorImpostoEsperado)
        {
            //Dado
            var produto = new ProdutoAlimento(nome, valor, quantidade);

            //Quando
            produto.CalcularValorImposto();

            //Então
            Assert.Equal(valorImpostoEsperado, produto.CalcularValorImposto());
        }

        [Theory]
        [InlineData("Notebook", 1000, 2, 0)]
        [InlineData("Monitor", 500, 4, 0)]
        public void CalcularValorImpostoDoProdutoEletronico(string nome, decimal valor, int quantidade, decimal valorImpostoEsperado)
        {
            //Dado
            var produto = new ProdutoEletronico(nome, valor, quantidade);

            //Quando
            produto.CalcularValorImposto();

            //Então
            Assert.Equal(valorImpostoEsperado, produto.CalcularValorImposto());
        }

        [Theory]
        [InlineData("Chiclete", 0.50, 5, 0.050)]
        [InlineData("Bala", 1.10, 10, 0.110)]
        public void CalcularValorImpostoDoProdutoSuperfulo(string nome, decimal valor, int quantidade, decimal valorImpostoEsperado)
        {
            //Dado
            var produto = new ProdutoSuperfluo(nome, valor, quantidade);

            //Quando
            produto.CalcularValorImposto();

            //Então
            Assert.Equal(valorImpostoEsperado, produto.CalcularValorImposto());
        }
    }
}