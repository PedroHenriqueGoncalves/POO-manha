using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AgregacaoContaArray
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }
        //Estabelecendo a agregação, por meio da
        //declaração de um atributo do tipo Cliente
        public List<Cliente> VetClientes { get; set; }
        public void Mostrar()
        {
            Console.WriteLine($"Número: {Numero} Saldo {Saldo:c}");
        }
        public Conta(int numero, double saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }
    }
}