using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Enums;
using System;

namespace Daycoval.Solid.Domain.Entities.Pagamento
{
    public abstract class Pagamento : Entity
    {
        public Pagamento(DateTime dataPagamento, DateTime? dataExpiracao, decimal totalPago, string pagador, EFormaPagamento formaPagamento)
        {
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            TotalPago = totalPago;
            Pagador = pagador;
            FormaPagamento = formaPagamento;
        }

        public DateTime DataPagamento { get; private set; }
        public DateTime? DataExpiracao { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Pagador { get; private set; }
        public EFormaPagamento FormaPagamento { get; private set; }
    }
}