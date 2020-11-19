using System;
using TDD_Example.Aplicação;
using TDD_Example.Repositorios;

namespace TDD_Example
{
    public class Program
    {
        public static IContasRepositorio contasRepositorio = new ContasRepositorio();
        public static IOperacoesConta operacoesConta = new OperacoesConta(contasRepositorio);

        public static void Main(string[] args)
        {

            Console.WriteLine("BEM VINDO AO SISTEMA DO BANCO X!"
                + "\n\nDigite o número correspondente à operação que deseja realizar:"
                + "\n\n1 - Depositar"
                + "\n2 - Sacar");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Depositar();
                    break;
                case 2:
                    Sacar();
                    break;
                default:
                    break;
            }
            Console.ReadKey();
        }

        public static void Depositar()
        {
            string cpf;
            decimal valor;

            Console.WriteLine("Digite o valor a ser depositado.");
            valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cpf do responsável pela conta");
            cpf = Console.ReadLine();

            Console.WriteLine(operacoesConta.Depositar(valor, cpf));
        }
        public static void Sacar()
        {
            string cpf;
            decimal valor;

            Console.WriteLine("Digite o valor a ser sacado.");
            valor = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cpf do responsável pela conta");
            cpf = Console.ReadLine();

            Console.WriteLine(operacoesConta.Sacar(valor, cpf));
        }
    }
}
