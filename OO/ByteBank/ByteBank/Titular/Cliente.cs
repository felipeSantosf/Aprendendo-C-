using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Titular
{
    public class Cliente
    {
        public static int quantidadeClientes { get; private set; }  
        public Cliente(string nome, string CPF, string profissao)
        {
            this.nome = nome;
            this.CPF = CPF;
            this.profissao = profissao;
            quantidadeClientes++;
        }
        public string nome { get; private set; }
        public string CPF { get; private set; }
        public string profissao { get; private set; }


    }
}
