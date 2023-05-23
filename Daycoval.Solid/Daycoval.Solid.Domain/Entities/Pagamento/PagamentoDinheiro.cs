using Daycoval.Solid.Domain.Entities.Enums;
using System;

namespace Daycoval.Solid.Domain.Entities.Pagamento
{
    public class PagamentoDinheiro : Pagamento
    {
        public PagamentoDinheiro(DateTime dataPagamento, DateTime? dataExpiracao, decimal totalPago, string pagador, EFormaPagamento formaPagamento, decimal valorRecebido)
            : base(dataPagamento, dataExpiracao, totalPago, pagador, formaPagamento)
        {
            ValorRecebido = valorRecebido;
        }

        public decimal ValorRecebido { get; private set; }

        public void SetValorRecebido(decimal valor)
        {
            // Adicionar validações, se necessário
            ValorRecebido = valor;
        }
    }


}
