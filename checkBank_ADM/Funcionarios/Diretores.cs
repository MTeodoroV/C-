using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkBank_ADM.Funcionarios
{
    public class Diretor: Funcionario
    {
        public double getBonificacao()
        {
            return Salario;
        }
    }
}