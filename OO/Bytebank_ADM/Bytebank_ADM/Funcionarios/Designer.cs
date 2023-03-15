using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class Designer:Funcionario
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.17;
        }

        public override void AumentarSalario()
        {
             this.Salario *= 1.1;
        }
        
        public Designer(string cpf, double salario): base(cpf, salario) 
        {

        }
    }
}
