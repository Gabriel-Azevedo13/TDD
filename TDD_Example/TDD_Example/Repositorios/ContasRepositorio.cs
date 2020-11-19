using System.Collections.Generic;

namespace TDD_Example.Repositorios
{
    public class ContasRepositorio : IContasRepositorio
    {

        public List<Conta> contas = new List<Conta>{
            new Conta(1000, "Marcos Silva", "11122233344"),
            new Conta(3000, "Maria Nunes", "11111111111"),
            new Conta(4000, "João Victor Oliveira", "12345678999"),
            new Conta(500, "Ana Luiza Martins", "12345678900") };

        public ContasRepositorio()
        {
        }

        public Conta? GetConta(string cpf)
        {
            foreach (var conta in contas)
            {
                if (conta.Cpf.Equals(cpf))
                    return conta;
            }
            return null;
        }
    }
}
