using ClasseAluno;
//Main()
Aluno a1 = new Aluno();
a1.nome = "Ana";
a1.nota1 = 10;
a1.nota2 = 9;
a1.ExibirDados();
Console.WriteLine(a1.VerificarAprovacao());
Aluno a2 = new Aluno();
a2.nome = "Teo";
a2.nota1 = 5;
a2.nota2 = 4;
a2.ExibirDados();
Console.WriteLine(a2.VerificarAprovacao());