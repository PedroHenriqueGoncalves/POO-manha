using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Produto
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }

        public void MostrarAtributos(){
            System.Console.WriteLine($"Codigo:{Codigo}, Nome:{Nome}, Preco:{Preco}");
        }

        public Produto(int codigo, string nome, double preco)
        {
            Codigo = 501;
            Nome = nome;
            Preco = preco;
        }
    }
}