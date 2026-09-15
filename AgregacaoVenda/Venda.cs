using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Venda
    {   
        public Vendedor vend { get; set; }
        public List<Produto> vetProd {get; set; }
        public Comprador comp { get; set; }
         public Venda()
        {
            vetProd = new List<Produto>(); 
        }

        public void MostrarAtributos()
        {
            System.Console.WriteLine("----Mostrar todos Atributos-----");
            vend.MostrarAtributos();
            comp.MostrarAtributos();
            System.Console.WriteLine("Produtos da Venda:");
            foreach(var p in vetProd)
            {
                p.MostrarAtributos();
            }
        }

    }
}