using EncapsulamentoFuncionario;
internal class Program
{
    private static void Main(string[] args)
    {
        Funcionario f1 = new Funcionario();
        f1.Salario = -10;
        Console.WriteLine("Salário: " + f1.Salario);
    }
}