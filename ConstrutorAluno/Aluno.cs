using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorAluno
{   
     public class Aluno
    {
        private string nome;
        private long ra;
        private static int qtd;
        public string Nome 
        { 
            get{ return nome; }
            set{nome = value; }
        }
        public long Ra 
        { 
            get{return ra;}
            set{ra = value;} 
        }
        
        public static int Qtd
        {
            get{return qtd;}
            set{qtd = value;}
        } 
        public Aluno(string nomeAluno, long raAluno)
            {
                Nome = nomeAluno;
                Ra = 1570482423000+raAluno;
                qtd++;
            }

        public void MostrarAtributos()
            {
                System.Console.WriteLine($"\tRA: {Ra} Nome: {Nome}");   
            }
        public void MostrarQtd()
        {
            System.Console.WriteLine($"\t Total de Alunos: {qtd}");
        }

    }
}