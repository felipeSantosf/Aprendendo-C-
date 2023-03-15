using Bytebank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public class GerenteDeContas:FuncionarioAutenticavel
    {
        public override double GetBonificacao()
        {
            return this.Salario * 1.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

        public GerenteDeContas(string cpf, double salario):base(cpf, salario) 
        {
        }
    }
}
