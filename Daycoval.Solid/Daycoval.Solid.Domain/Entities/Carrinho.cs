using System.Collections.Generic;

namespace Daycoval.Solid.Domain.Entities
{
    public class Carrinho
    {
        public decimal ValorTotalPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        public Cliente Cliente { get; set; }
        public bool FoiPago { get; set; }
        public bool FoiEntregue { get; set; }
    }
}