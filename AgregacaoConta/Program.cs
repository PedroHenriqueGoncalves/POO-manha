using AgregacaoConta;

Cliente cli = new Cliente("Ana",123);

Conta c1 = new Conta(1,1000);
//Efetivação da agregação, por meio da 
//atribuição/armazenamento do objeto cli, assim
//o Titular que era um atributo, passa a ser um
//objeto
c1.Titular = cli;
cli.Mostrar();
c1.Mostrar();
//ou
c1.Titular.Mostrar();

Conta c2 = new Conta(2,2000);
c2.Titular = new Cliente("Bia", 124);
c2.Mostrar();
c2.Titular.Mostrar();
