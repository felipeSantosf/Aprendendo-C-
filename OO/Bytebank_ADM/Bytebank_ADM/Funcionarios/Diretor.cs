using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.50;
        }

        public override double GetPremiacaoSemestral()
        {
            return this.Salario * 1.15;
        }

        public override void AumentarSalario()
        {
            this.Salario = Salario * 1.15;
        }

        public Diretor(string cpf, double salario): base(cpf, salario)
        {

        }
    }
}
