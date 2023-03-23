using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_exception
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {
        public SaldoInsuficienteException(string mensagem) : base(mensagem) 
        
        {

        }
    }
}
