using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Vendedor
    {
        public double Comissao { get ; set; }

        public void Mostrar(){
            System.Console.WriteLine($"Valor da Comissão: {Comissao}");
        }

        public void CalcularComissao(double preco){
             Comisao = preco * 0.02;
        }
    }

}