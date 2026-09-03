using EncapsulamentoConta;
internal class Program
{
    private static void Main(string[] args)
    {
        Conta c1 = new Conta();
        //dá erro, pois o atributo numero está private
        //c1.numero = 1;
        c1.Numero = 1; // aqui foi usado o método set
        c1.Titular = "Ana";
        c1.Saldo = 100;
        //aqui foi usado o método get
        Console.WriteLine("Valor do saldo " + c1.Saldo);
        //if (c1.Saldo < 0) -> método get

        c1.MostrarAtributos();
    }
}