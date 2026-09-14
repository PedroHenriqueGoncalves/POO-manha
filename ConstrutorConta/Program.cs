using ConstrutorConta;
Conta c1 = new Conta();
c1.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);

Conta c2 = new Conta(1);
c2.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);

Conta c3 = new Conta(2,"Ana", 200);
c3.MostrarAtributos();
Console.WriteLine("Qtde: " + Conta.Contador);