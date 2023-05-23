using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Pagamento;
using Daycoval.Solid.Domain.Services.Interfaces;
using System;

namespace Daycoval.Solid.Domain.Services
{
    public class GatewayPagamentoService : IPagamentoService
    {
        private readonly string _login;
        private readonly string _senha;

        public GatewayPagamentoService(string login, string senha)
        {
            _login = login;
            _senha = senha;
        }


        public void EfetuarPagamento(Carrinho carrinho, Pagamento pagamento)
        {
            //Não é necessário implementar este método.
            //throw new NotImplementedException();
            carrinho.Pagar();
        }


    }
}