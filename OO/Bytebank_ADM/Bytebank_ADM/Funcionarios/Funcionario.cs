using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.Funcionarios
{
    public abstract class Funcionario
    {

        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

       

        public static int totalFuncionario { get; private set; }
        public abstract double GetBonificacao();
       
        
        public virtual double GetPremiacaoSemestral()
        {
            return Salario * 20 / 100;
        }

        public abstract void AumentarSalario();

        

        public Funcionario(string Cpf, double salario)
        {
            this.Nome = Cpf;
            this.Salario = salario; 
            totalFuncionario++;
        }
    }
}
