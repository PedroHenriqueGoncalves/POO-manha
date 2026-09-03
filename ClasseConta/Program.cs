using ClasseConta;
internal class Program
{
    private static void Main(string[] args)
    {
        //declaração de variável
        //tipo nomedavariável;
        Conta c1;
        //instanciar o objeto
        c1 = new Conta();
        c1.numero = 19;
        c1.titular = "Ana";
        c1.saldo = 1000.52;
        c1.MostrarAtributos();
        Console.Write("Informe qual valor a sacar: ");
        double valorSaque = Convert.ToDouble(Console.ReadLine());
        c1.Sacar(valorSaque);
        c1.MostrarAtributos();
        Conta c2 = new Conta();
        Console.Write("Digite o número: ");
        c2.numero = Convert.ToInt32(Console.ReadLine());
        Console.Write("Digite o titular: ");
        c2.titular = Console.ReadLine();
        Console.Write("Digite o saldo: ");
        c2.saldo = Convert.ToDouble(Console.ReadLine());
        c2.MostrarAtributos();
        c1.Transferir(20,c2);
        c1.MostrarAtributos();
        c2.MostrarAtributos();
        Conta c3 = new Conta();
        c3.MostrarAtributos();
        Console.Write("Informe qual valor será depositado: ");
        double valorDeposito = Convert.ToDouble(Console.ReadLine());
        c3.Depositar(valorDeposito);
        c3.MostrarAtributos();
    }
}