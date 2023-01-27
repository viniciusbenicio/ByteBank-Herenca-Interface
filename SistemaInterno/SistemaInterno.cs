using ByteBank.ADM.Funcionarios;
using ByteBank.ADM.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ADM.SistemaInterno
{
    public class SistemaInterno
    {

        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Boas vinda ao nosso Sistema....");
                return true;
            }
            else
            {
                Console.WriteLine("Ocorreu um erro ao tentar autenticar...");
                return false;
            }

        }
    }
}
