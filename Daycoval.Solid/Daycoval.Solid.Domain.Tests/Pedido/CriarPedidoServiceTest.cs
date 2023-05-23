using Daycoval.Solid.Domain.Entities.Cliente;
using Daycoval.Solid.Domain.Entities.DomainObject;
using Daycoval.Solid.Domain.Entities.Pagamento;
using Daycoval.Solid.Domain.Services;
using Daycoval.Solid.Domain.Services.Interfaces;
using Moq;

namespace Daycoval.Solid.Domain.Tests.Pedido;

public class CriarPedidoServiceTest
{
    [Fact]
    public void EfetuarPedidoComDadosValidos()
    {
        //Arrange(Dado)
        var clienteDocumento = new Documento("12345678909");
        var clienteNome = new Nome("Victor", "Perez");
        var clienteEmail = new Email("victorperez.ti@outlook.com.br");
        var clienteTelefone = new Telefone("61991234567", Entities.Enums.ETipoTelefone.Celular);
        var cliente = new Cliente(clienteDocumento, clienteNome, clienteEmail, clienteTelefone);
        var carrinho = new Carrinho(cliente);

        var detalhePagamento = new PagamentoCartaoCredito(
            DateTime.UtcNow,
            DateTime.Now.AddYears(1),
            1000m,
            clienteNome.ToString(),
            Entities.Enums.EFormaPagamento.CartaoCredito,
            clienteNome.ToString(),
            "1234567890",
            123
            );

        var notificarClienteEmail = true;
        var notificarClienteSms = true;

        var pagamentoServiceMock = new Mock<IPagamentoService>();
        var estoqueServiceMock = new Mock<IEstoqueService>();
        var smsServiceMock = new Mock<ISmsService>();
        var emailServiceMock = new Mock<IEmailService>();

        estoqueServiceMock.Setup(x => x.SolicitarProduto(carrinho.Produtos));
        pagamentoServiceMock.Setup(x => x.EfetuarPagamento(carrinho, detalhePagamento));
        estoqueServiceMock.Setup(x => x.ProcessarPedido(carrinho));
        estoqueServiceMock.Setup(x => x.BaixarEstoque(carrinho.Produtos));

        //Act(Quando)
        var pedidoService = new PedidoService(
            pagamentoServiceMock.Object,
            estoqueServiceMock.Object,
            smsServiceMock.Object,
            emailServiceMock.Object
        );

        pedidoService.EfetuarPedido(carrinho, detalhePagamento, notificarClienteEmail, notificarClienteSms);

        // Assert (Então)
        estoqueServiceMock.Verify(x => x.SolicitarProduto(carrinho.Produtos), Times.Once);
        pagamentoServiceMock.Verify(x => x.EfetuarPagamento(carrinho, detalhePagamento), Times.Once);
        estoqueServiceMock.Verify(x => x.ProcessarPedido(carrinho), Times.Once);
        estoqueServiceMock.Verify(x => x.BaixarEstoque(carrinho.Produtos), Times.Once);
        emailServiceMock.Verify(x => x.EnviarEmail(
            carrinho.Cliente.Email.EnderecoEmail,
            "tiago.dantas@bancodaycoval.com.br",
            "Dados da sua compra",
            "Obrigado por efetuar sua compra conosco."
        ), Times.Once);
        smsServiceMock.Verify(x => x.EnviarSms(carrinho.Cliente.Telefone, "Obrigado por efetuar sua compra conosco."), Times.Once);
    }
}