using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Item
{
    public class Pizza
    {
        private string nome;
        private double valor;
        private double desconto;


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void setDesconto(double desconto)
        {
            this.desconto = desconto;
        }

        public void exibirProduto()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Valor: " + this.valor);
            Console.WriteLine("desconto: " + this.desconto);

        }
    }
}
