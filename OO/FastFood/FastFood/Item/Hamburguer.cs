using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastFood.Item
{
    public class Hamburguer
    {
        private string nome;
        private double valor;
        private double desconto;
        private int quantidade = 0;
        private double total;


        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public void setValor(double valor)
        {
            this.valor = valor;
        }

        public void setPercentualDesconto(double desconto)
        {
            this.desconto = desconto;
        }

        public void exibirProduto()
        {
            Console.WriteLine("Nome: " + this.nome);
            Console.WriteLine("Valor: " + this.valor);
            Console.WriteLine("desconto: " + this.desconto + "%");

        }

        public void adicionarProduto()
        {
            quantidade++;
            Console.WriteLine("Quantidade adicionada com sucesso");
        }

        public void removerProduto()
        {
            if (quantidade > -1)
            {
                quantidade--;
                Console.WriteLine("quantidade removida com sucesso;");
            }
            else
            {
                Console.WriteLine("Quantidade 0 não foi possível remover");
            }
        }

        public void obterValor()
        {
            total = quantidade * valor - (quantidade * valor * desconto / 100);
            Console.WriteLine("Total R$: " + total.ToString("F"));
        }

    }
}
