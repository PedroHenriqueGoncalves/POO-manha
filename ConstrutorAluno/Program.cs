using System;

namespace ConstrutorAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno a1 = new Aluno("Pedro",1);
            Aluno a2 = new Aluno("Ana",2);
            Aluno a3 = new Aluno("Jose",3);
            
            a1.MostrarAtributos();
            a2.MostrarAtributos();
            a3.MostrarAtributos();

            a3.MostrarQtd();          
        }
    }
}



