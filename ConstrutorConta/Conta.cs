using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConstrutorConta
{
    public class Conta
    {
        // declarando as propriedades, que dentro delas
        // estão os atributos (de forma implícita) e os
        // métodos get-set
        public int Numero { get; set; }
        public string? Titular { get; set; }
        public double Saldo { get; set; }
        public static int Contador { get; set; }
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {Numero} Titular: {Titular} Saldo {Saldo:c}");
        }
        public Conta()
        {
            Contador ++;
        }
        public Conta(int numero)
        {
            this.Numero = numero;
            Contador = Contador + 1;
        }
        public Conta(int numero, string? titular, double saldo)
        {
            Contador += 1;
            Numero = numero;
            Titular = titular;
            Saldo = saldo;
        }
    }
}