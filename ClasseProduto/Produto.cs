using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClasseProduto
{
    public class Produto
    {
        //declaração de atributos
        public string nome;
        public int qtde;
        public double preco;
        //declaração de métodos
        public void AdicionarProduto(int qtd)
        {// qtde += qtd;
            qtde = qtde + qtd;
        }
        public void RemoverProduto(int qtd)
        {//qtde = qtde - qtd;
            qtde -= qtd;
        }
        public double ValorTotalEstoque()
        {
            return qtde * preco;
        }
        public void MostarAtributos()
        {
            Console.WriteLine($"Nome: {nome} \tQtde: {qtde} \tPreço {preco:c}");
        }
    }
}