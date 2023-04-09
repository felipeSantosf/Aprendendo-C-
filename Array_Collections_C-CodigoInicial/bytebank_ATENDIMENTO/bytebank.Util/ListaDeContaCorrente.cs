using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens = null;
        private int _proximaPosicao = 0;
        public ListaDeContaCorrente(int tamanhoInicial = 5)
        {
            _itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            if (VerificarCapacidade())
            {
                _itens[_proximaPosicao] = item;
                _proximaPosicao++;
            } else
            {
                Console.WriteLine("Verifique a capacidade do array");
            }
        }

        private bool VerificarCapacidade()
        {
            if (_proximaPosicao < _itens.Length) { return true; }
            else { return false; }
        }
    }
}
