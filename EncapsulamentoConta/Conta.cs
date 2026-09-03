using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EncapsulamentoConta
{
    public class Conta
    {
        //declarar os atributos com encapsulamento
        private int numero;
        private string? titular;
        private double saldo;

        //criar os métodos de encapsulamento de 
        //cada atributo set/get
        public int Numero{ //definição da propriedade
            set{
                this.numero = value;
            }
            get{
                return this.numero;
            }
        }
        public string? Titular{ //definição da propriedade
            set{
                this.titular = value;
            }
            get{
                return this.titular;
            }
        }
        public double Saldo{ //definição da propriedade
            set{
                this.saldo = value;
            }
            get{
                return this.saldo;
            }
        }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} Saldo {saldo:c}");
        }
    }
}