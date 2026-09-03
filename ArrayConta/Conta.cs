using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//pasta-subpasta
namespace ArrayConta
{
    public class Conta
    {
        //declaração de atributos
        //variáveis de tipos primitivos, int, float
        public int numero;
        public string titular;
        public double saldo;
        //declaração dos métodos-funções
        public void MostrarAtributos()
        {
            Console.WriteLine($"Número: {numero} \tTitular: {titular} Saldo {saldo:c}");
        }
        public void Sacar(double saque)
        {
            saldo = saldo - saque;
        } 
        public void Depositar(double deposito)
        {
            saldo = saldo + deposito;
        }
        public void Transferir(double valorTransferencia,
                               Conta objContaDestino)
        {
            saldo = saldo - valorTransferencia;
            objContaDestino.saldo += valorTransferencia;
        }
    }
}