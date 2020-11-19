using TDD_Example.Aplicação;
using Xunit;

namespace TestClass
{
    public class TestesConta
    {

        [Fact]
        public void SeSaqueMenorQueSaldo_RetornaValorDoSaqueESaldoAtual()
        {
            var contaRepositorioMoq = ContasRepositorioMock.Instance().Setup_GetConta(500, "Luiz Henrique Farnetti", "44444444444").Mock();
            var sut = new OperacoesConta(contaRepositorioMoq.Object);
            var result = sut.Sacar(400, "12345678900");

            Assert.Equal("Saque efetuado com sucesso! Seu saldo atual é de $100.", result);
        }

        [Fact]
        public void SeDepositoMenorQue4000_RetornaDepositoEfetuadoComSucesso()
        {
            var contaRepositorioMoq = ContasRepositorioMock.Instance().Setup_GetConta(500, "Luiz Henrique Farnetti", "44444444444").Mock();
            var sut = new OperacoesConta(contaRepositorioMoq.Object);
            var result = sut.Depositar(1000, "12345678900");

            Assert.Equal("Depósito efetuado com sucesso! Seu saldo atual é de $1500.", result);
        }

        [Fact]
        public void SeSaqueMaiorQueSaldo_RetornaSaldoInsuficiente()
        {
            var contaRepositorioMoq = ContasRepositorioMock.Instance().Setup_GetConta(400, "Luiz Henrique Farnetti", "44444444444").Mock();
            var sut = new OperacoesConta(contaRepositorioMoq.Object);
            var result = sut.Sacar(9000, "12345678900");

            Assert.Equal("Saldo Indisponível! Seu saldo atual é de $400.", result);
        }

        [Fact]
        public void SeDepositoMaiorQue4000_RetornaImpossivelRealizarDeposito()
        {
            var contaRepositorioMoq = ContasRepositorioMock.Instance().Setup_GetConta(400, "Luiz Henrique Farnetti", "44444444444").Mock();
            var sut = new OperacoesConta(contaRepositorioMoq.Object);
            var result = sut.Depositar(4500, "12345678900");

            Assert.Equal("Impossível efetuar o depósito. O valor máximo de depósito é de 4000 reais.", result);
        }
    }
}
