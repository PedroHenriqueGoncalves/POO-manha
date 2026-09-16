using AgregacaoVenda;
Vendedor vendedor = new Vendedor();
Comprador comprador = new Comprador{Verba = 10000};

Produto p1 = new Produto(501,"Teclado", 100.00 );
Produto p2 = new Produto(502,"Mouse",50.00);

Venda v1 = new Venda();

v1.vend = vendedor;
v1.comp = comprador;

v1.vetProd.Add(p1);
v1.vetProd.Add(p2);

vendedor.CalcularComissao(p1.Preco);
vendedor.CalcularComissao(p2.Preco);

comprador.DiminuirVerba(p1.Preco);
comprador.DiminuirVerba(p2.Preco);

comprador.MostrarAtributos();
