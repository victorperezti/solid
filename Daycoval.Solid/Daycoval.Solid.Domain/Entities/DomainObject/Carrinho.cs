using System;
using System.Collections.Generic;
using Daycoval.Solid.Domain.Services.Interfaces;

namespace Daycoval.Solid.Domain.Entities.DomainObject
{
    public class Carrinho
    {
        private readonly List<Produto.Produto> _produtos;
        private readonly Cliente.Cliente _cliente;
        private bool _foiPago;
        private bool _foiEntregue;

        public decimal ValorTotalPedido => CalcularValorTotalPedido();

        public List<Produto.Produto> Produtos => _produtos;
        public Cliente.Cliente Cliente => _cliente;
        public bool FoiPago => _foiPago;
        public bool FoiEntregue => _foiEntregue;
        public IPagamentoService FormaPagamento { get; set; }

        public Carrinho(Cliente.Cliente cliente)
        {
            _produtos = new List<Produto.Produto>();
            _cliente = cliente;
            _foiPago = false;
            _foiEntregue = false;
        }

        public void AdicionarProduto(Produto.Produto produto) => _produtos.Add(produto);

        public void RemoverProduto(Produto.Produto produto) => _produtos.Remove(produto);

        public void Pagar()
        {
            if (FormaPagamento == null)
            {
                throw new InvalidOperationException("A forma de pagamento não foi definida.");
            }
            
            _foiPago = true;
        }

        public void Entregar() => _foiEntregue = true;

        private decimal CalcularValorTotalPedido()
        {
            decimal valorTotal = 0;

            foreach (var produto in _produtos)
            {
                valorTotal += produto.Valor;
            }

            return valorTotal;
        }
    }
}
