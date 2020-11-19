using Moq;
using TDD_Example;
using TDD_Example.Repositorios;

namespace TestClass
{
    public class ContasRepositorioMock : MoqBase<IContasRepositorio, ContasRepositorioMock>
    {
        public ContasRepositorioMock Setup_GetConta(decimal saldo, string nome, string cpf)
        {
            Conta conta = new Conta(saldo, nome, cpf);
            mock.Setup(x => x.GetConta(It.IsAny<string>())).Returns(conta);
            return this;
        }
    }
}
