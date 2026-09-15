using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoVenda
{
    public class Comprador
    {
        private double verba;
        public double Verba { 
                    get{return verba;}
                    set{ verba = value;}
            }
        
        public void DiminuirVerba(double preco){
            verba = verba - preco; 
        }
        public void MostrarAtributos(){
            System.Console.WriteLine($"Verba do comprador: {verba:c}");
        }

    }
}