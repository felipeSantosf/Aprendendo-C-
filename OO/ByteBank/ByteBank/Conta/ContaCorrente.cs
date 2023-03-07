using ByteBank.Titular;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Conta
{
    public class ContaCorrente
    {
        public int numero_agencia;
        public string conta;
        public double saldo = 100;

        public Cliente titular;

        public void Depositar(double valor)
        {
            saldo += valor;
        }

        public bool Sacar(double valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                return true;
            }

            return false;
        }


        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (saldo >= valor)
            {
                contaDestino.saldo += valor;
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void exibirInformacoesConta()
        {
            Console.WriteLine("Número da agência: " + numero_agencia);
            Console.WriteLine("Número da conta: " + conta);
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Saldo: " + saldo);
        }
    }
}
