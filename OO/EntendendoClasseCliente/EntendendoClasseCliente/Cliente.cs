using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloCliente
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return $"Nome: {this.Nome}, \n" +
                   $"CPF: {this.Cpf}, \n" +
                   $"Email: {this.Email}, \n" +
                   $"Idade: {this.Idade}";
        }
    }
}
