using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.20;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.1;
        }

        
        public Auxiliar(string cpf, double salario) : base(cpf, salario)
        {
        }
    }
}

