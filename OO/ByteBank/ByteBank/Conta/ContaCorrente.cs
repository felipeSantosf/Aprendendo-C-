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
        public static int quantidadeContasCriadas { get; private set; }    
        public string Numero_Conta { get; set; }

        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            set
            {
                if (value > 0)
                    this.numero_agencia = value;
            }
        }
        public string Conta { get; set; }
        private double saldo = 100;
        

        public Cliente titular { get; set; }

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

        public void DefinirSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo += valor;
            }
        }

        public double ObterSaldo()
        {
            return this.saldo;
        }
        public void exibirInformacoesConta()
        {
            Console.WriteLine("Número da agência: " + this.Numero_agencia);
            Console.WriteLine("Número da conta: " + this.Conta);
            Console.WriteLine("Titular: " + this.titular);
            Console.WriteLine("Saldo: " + this.saldo);
        }

        public ContaCorrente(int numero_agencia, string conta) 
        {
            this.Numero_agencia = numero_agencia;
            this.Conta = conta;
            quantidadeContasCriadas++;
        }
    }
}
