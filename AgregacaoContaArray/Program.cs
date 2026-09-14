using AgregacaoContaArray;

Cliente cli1 = new Cliente("Ana", 123);
Cliente cli2 = new Cliente("Bia", 124);

Conta c1 = new Conta(1, 10000);
c1.VetClientes = new List<Cliente>();
c1.VetClientes.Add(cli1);
c1.VetClientes.Add(cli2);
c1.Mostrar();
foreach (var objCliente in c1.VetClientes)
{
    objCliente.Mostrar();
}