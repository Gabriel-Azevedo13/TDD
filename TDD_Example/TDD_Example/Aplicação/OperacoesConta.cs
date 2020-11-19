using TDD_Example.Repositorios;

namespace TDD_Example.Aplicação
{
    public class OperacoesConta : Conta, IOperacoesConta
    {
        private IContasRepositorio contasRepositorio;
        public OperacoesConta()
        {
        }
        public OperacoesConta(IContasRepositorio contasRepositorio)
        {
            this.contasRepositorio = contasRepositorio;
        }
        public string Sacar(decimal valorSacado, string cpf)
        {
            Conta contaCliente = contasRepositorio.GetConta(cpf);

            if (valorSacado < contaCliente.Saldo)
            {
                if (contaCliente == null)
                {
                    return $"Impossível efetuar o saque. Não existe conta para o cpf informado.";
                }
                contaCliente.Saldo -= valorSacado;

                return $"Saque efetuado com sucesso! Seu saldo atual é de ${contaCliente.Saldo}.";
            }
            else
            {
                return $"Saldo Indisponível! Seu saldo atual é de ${contaCliente.Saldo}.";
            }
        }

        public string Depositar(decimal valorDeposito, string cpf) //O valor máximo do depósito é 4000 reais
        {
            Conta contaCliente = contasRepositorio.GetConta(cpf);

            if (valorDeposito < 4000)
            {
                if (contaCliente == null)
                {
                    return $"Impossível efetuar o depósito. Não existe conta para o cpf informado.";
                }

                contaCliente.Saldo += valorDeposito;

                return $"Depósito efetuado com sucesso! Seu saldo atual é de ${contaCliente.Saldo}.";
            }
            else
            {
                return $"Impossível efetuar o depósito. O valor máximo de depósito é de 4000 reais.";
            }
        }
    }
}
