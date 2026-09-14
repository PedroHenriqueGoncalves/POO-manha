using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        public double Verba { 
                    get{return Verba;}
                    set {Verba = value;}
        }


        public void DiminuirVerba(double preco){
            Verba = Verba - preco; 
        }
        public void Mostrar(){
            System.Console.WriteLine($"Verba do comprador: {Verba:c}");
        }

    }
}