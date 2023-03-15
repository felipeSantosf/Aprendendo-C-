using OperacoesMatematicas.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperacoesMatematicas
{
    public class OperacaoMatematica
    {
        public Somar Soma { get; private set; }
        public Dividir Divisao { get; private set; }
        public Multiplicar Multiplicacao { get; private set; }
        public Subtrair Subtracao { get; private set; }

        public OperacaoMatematica() 
        {
            this.Soma = new Somar();
            this.Divisao = new Dividir();
            this.Multiplicacao = new Multiplicar();  
            this.Subtracao = new Subtrair();
        }  
    }
}
