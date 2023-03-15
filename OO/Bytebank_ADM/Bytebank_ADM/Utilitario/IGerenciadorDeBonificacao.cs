using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Utilitario
{
    public interface IGerenciadorDeBonificacao
    {
        public double TotalBonificacoes { get; set; }


        // Polimorfismo
        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacoes += funcionario.GetBonificacao();
        }

        public void RegistrarPremiacaoSemestral(Funcionario funcionario)
        {
            this.TotalBonificacoes += funcionario.GetPremiacaoSemestral();
        }

    }
}
