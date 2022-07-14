using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkBank_ADM.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
            System.Console.WriteLine("Criando designer");
        }
        public override double getBonificacao()
        {
            return Salario *= 0.17;
        }

        public override void aumentarSalario()
        {
            Salario *= 1.11;
        }
    }
}