using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel 
    {
            
        public string Senha { protected get; set; }

        public string Login { protected get; set; } 
      

        public abstract bool Autenticar(string login, string senha);
    }
}
