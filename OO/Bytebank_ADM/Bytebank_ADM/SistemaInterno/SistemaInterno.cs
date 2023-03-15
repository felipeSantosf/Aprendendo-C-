using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public class SistemaInterno
    {
        public bool logar(IAutenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vindas ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário ou senha incorreto, tente novamente!");
                return false;
            }

        }


    }

}

