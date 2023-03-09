using FastFood.Item;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Cliente
{
    public class Cliente
    {
        private string nomeCliente;
        private string cpfCliente;
        private string cepCliente;
        private string ruaCliente;
        private int numeroCliente;
        private string bairroCliente;
        private string cidadeCliente;
        private string estadoCliente;
        private string complementoCliente;


        public Hamburguer hamburguer;
        public Pizza pizza;
        public CachorroQuente cachorroQuente;


        public void setNomeCliente(string nomeCliente)
        {
            this.nomeCliente = nomeCliente;
        }

        public void setCpfCliente(string cpfCliente)
        {
            this.cpfCliente = cpfCliente;
        }

        public void setCEPCliente(string cepCliente)
        {
            this.cepCliente = cepCliente;
        }



        public void setRuaCliente(string ruaCliente)
        {
            this.ruaCliente = ruaCliente;
        }

        public void setNumeroCliente(int numeroCliente)
        {
            this.numeroCliente = numeroCliente;
        }

        public void setBairroCliente(string bairroCliente)
        {
            this.bairroCliente = bairroCliente;
        }

        public void setCidadeCliente(string cidadeCliente)
        {
            this.cidadeCliente = cidadeCliente;
        }

        public void setEstadoCliente(string estadoCliente)
        {
            this.estadoCliente = estadoCliente;
        }

        public void setComplementoCliente(string complementoCliente)
        {
            this.complementoCliente = complementoCliente;   
        }

        public void exibirCliente()
        {
            Console.WriteLine("Nome do cliente: " + this.nomeCliente);
            Console.WriteLine("Cpf do cliente: " + this.cpfCliente);
            Console.WriteLine("Cep do cliente: " + this.cepCliente);
            Console.WriteLine("Rua do cliente: " + this.ruaCliente);
            Console.WriteLine("Numero do cliente: " + this.numeroCliente);
            Console.WriteLine("Bairro do cliente: " + this.bairroCliente);
            Console.WriteLine("Cidade do cliente: " + this.cidadeCliente);
            Console.WriteLine("Estado do cliente: " + this.estadoCliente);
        }

    }
}
