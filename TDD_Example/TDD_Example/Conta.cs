namespace TDD_Example
{
    public class Conta
    {
        public decimal Saldo { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public Conta()
        {
        }
        public Conta(decimal saldo, string nome, string cpf)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.Saldo = saldo;

        }
    }
}
