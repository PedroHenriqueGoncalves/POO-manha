using ClasseProduto;
//  main
//instancia de objeto
Produto p1 = new Produto();
p1.MostarAtributos();
p1.nome = "Mouse";
p1.preco = 50;
p1.AdicionarProduto(10);
p1.MostarAtributos();
Produto p2 = new Produto();
p2.nome = "Impressora";
p2.qtde = 5;
p2.preco = 300;
p2.MostarAtributos();
p2.RemoverProduto(2);
p2.MostarAtributos();
Console.WriteLine($"Total: {p2.ValorTotalEstoque():c}");

