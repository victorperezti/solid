using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Pagamento;
using Daycoval.Solid.Domain.Services.Interfaces;

namespace Daycoval.Solid.Domain.Services
{
    public class PedidoService : IPedidoService
    {
        private readonly IPagamentoService _pagamentoService;
        private readonly IEstoqueService _estoqueService;
        private readonly ISmsService _smsService;
        private readonly IEmailService _emailService;

        public PedidoService(IPagamentoService pagamentoService, IEstoqueService estoqueService, ISmsService smsService, IEmailService emailService)
        {
            _pagamentoService = pagamentoService;
            _estoqueService = estoqueService;
            _smsService = smsService;
            _emailService = emailService;
        }

        public void EfetuarPedido(Carrinho carrinho, Pagamento detalhePagamento, bool notificarClienteEmail, bool notificarClienteSms)
        {
            _estoqueService.SolicitarProduto(carrinho.Produtos);
            _pagamentoService.EfetuarPagamento(carrinho, detalhePagamento);
            _estoqueService.ProcessarPedido(carrinho);
            _estoqueService.BaixarEstoque(carrinho.Produtos);

            if (notificarClienteEmail)
                _emailService.EnviarEmail(carrinho.Cliente.Email.EnderecoEmail, "tiago.dantas@bancodaycoval.com.br", "Dados da sua compra", "Obrigado por efetuar sua compra conosco.");

            if (notificarClienteSms)
                _smsService.EnviarSms(carrinho.Cliente.Telefone, "Obrigado por efetuar sua compra conosco.");

        }

    }
}