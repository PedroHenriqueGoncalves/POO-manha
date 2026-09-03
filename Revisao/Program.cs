internal class Program
{
    private static void Main(string[] args)
    {
        /*
        Console.Write("Digite o ano de nascimento: ");
        int ano = Convert.ToInt32(Console.ReadLine());
        int idade = 2026 - ano;
        Console.WriteLine("Sua idade é " + idade + " anos.");
        //Estrutura de decisão
        if (idade >= 18)
            Console.WriteLine("Maior idade");
        else if (idade > 0 && idade <= 4)
        {
            Console.Write("Você é ");
            Console.WriteLine("Nenem");
        }
        else
            Console.WriteLine("Menor idade");
        int opcao = 1;
        switch (opcao) // opcao == 1
        {
            case 1: Console.WriteLine("Opção 1 selecionada");
                    break;
            case 2: Console.WriteLine("Opção 2 selecionada");
                    break;
            default: Console.WriteLine("Opção inválida");
                     break;
        }
        */
        Console.WriteLine("While ..... incremento.....");
        int cont = 1;
        while (cont <= 10)
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont = cont + 1;//incremento
        }
        Console.WriteLine("For ..... incremento.....");
        for (cont = 1; cont <= 10; cont ++)
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
        Console.WriteLine("Do while ..... incremento.....");
        cont = 1;
        do{
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont ++;//incremento
        } while (cont <= 10);
        Console.WriteLine("while ..... decremento.....");
        cont = 10;
        while (cont >= 1)
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont = cont - 1; // decremento
        }
        Console.WriteLine("for ..... decremento.....");
        for (cont = 10; cont >= 1; cont--)
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
        Console.WriteLine("do while ..... decremento.....");
        do
        {
            Console.WriteLine("6 * " + cont + " = " + 6 * cont);
            cont = cont - 1; // decremento
        } while (cont >= 1);
        Console.WriteLine("foreach ..... incremento.....");
        int[] idades = [92, 75, 39, 46, 54];
        int soma_idades = 0;
        foreach (int item in idades)
        {
            Console.WriteLine(item);
            soma_idades += item;
        }
        float media = soma_idades / 5;
        Console.WriteLine("Média de idade " + media);
        soma_idades = 0;
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(idades[i]);
            soma_idades += idades[i];
        }
    }
}