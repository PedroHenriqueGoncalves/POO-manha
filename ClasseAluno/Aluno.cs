using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseAluno
{
    public class Aluno
    {
        //declaração de atributos
        public string nome;
        public double nota1;
        public double nota2;
        //declaração de métodos-funções
        public double CalcularMedia() 
        {
            return (nota1 + nota2) / 2;
        }
        public string VerificarAprovacao()
        {// (média ≥ 6).
            if (CalcularMedia() >= 6)
                return "Aluno aprovado";
            else
                return "Aluno reprovado";
        } 
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {nome} \t Nota 1: {nota1:n} \t Nota 2: {nota2:n} \t Média: {CalcularMedia():n}");
        }
    }
}