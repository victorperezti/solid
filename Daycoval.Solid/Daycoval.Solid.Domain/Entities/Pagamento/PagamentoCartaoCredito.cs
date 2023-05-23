﻿using Daycoval.Solid.Domain.Entities.Enums;
using System;

namespace Daycoval.Solid.Domain.Entities.Pagamento
{
    public class PagamentoCartaoCredito : Pagamento
    {
        public PagamentoCartaoCredito(DateTime dataPagamento, DateTime? dataExpiracao, decimal totalPago, string pagador, EFormaPagamento formaPagamento, string nomeImpressoCartao, string numeroCartao, int cvv)
            : base(dataPagamento, dataExpiracao, totalPago, pagador, formaPagamento)
        {
            NomeImpressoCartao = nomeImpressoCartao;
            NumeroCartao = numeroCartao;
            Cvv = cvv;
        }

        public string NomeImpressoCartao { get; set; }
        public string NumeroCartao { get; set; }
        public int Cvv { get; set; }

        public void SetNomeImpressoCartao(string nome)
        {
            // Adicionar validações, se necessário
            NomeImpressoCartao = nome;
        }

        public void SetNumeroCartao(string numero)
        {
            // Adicionar validações, se necessário
            NumeroCartao = numero;
        }

        public void SetCvv(int cvv)
        {
            // Adicionar validações, se necessário
            Cvv = cvv;
        }
    }
}