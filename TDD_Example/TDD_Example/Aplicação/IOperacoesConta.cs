namespace TDD_Example.Aplicação
{
    public interface IOperacoesConta
    {
        string Sacar(decimal valorSacado, string cpf);
        string Depositar(decimal valorDeposito, string cpf);
    }
}
