using ByteBank.ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.ADM.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalBonificacao { get; private set; }

        public void Registrar(Funcionario funcionario)
        {
            this.TotalBonificacao += funcionario.GetBonificacao();
        }
       

    }
}
