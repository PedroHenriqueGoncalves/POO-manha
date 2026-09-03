using ArrayConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cadastro de contas...");
        //declaração de um vetor com 3 índices
        Conta[] vetConta = new Conta[3];
        double soma = 0;
        for (int i = 0; i < vetConta.Length; i++)
        {
            //instanciação de objeto em cada índice
            vetConta[i] = new Conta();
            Console.Write("Cadastre o número: ");
            vetConta[i].numero = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cadastre o titular: ");
            vetConta[i].titular = Console.ReadLine();
            Console.Write("Cadastre o saldo: ");
            vetConta[i].saldo = Convert.ToDouble(Console.ReadLine());
            soma = soma + vetConta[i].saldo;
        }
        Console.WriteLine($"Total do vetConta {soma:c}\n");
        Console.WriteLine("Exemplo do foreach...");
        soma = 0;
        foreach (Conta c in vetConta)
        {
            c.MostrarAtributos();
            soma += c.saldo;//soma = soma + c.saldo;
        }
        Console.WriteLine($"Total do objeto c {soma:c}\n");
        Console.WriteLine("Exemplo do for...");
        for (int i = 0; i < vetConta.Length; i++)
            vetConta[i].MostrarAtributos();
        //Calcule a soma dos saldos, escolha o for e o foreach
    }
}