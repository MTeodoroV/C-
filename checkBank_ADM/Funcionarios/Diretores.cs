using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkBank_ADM.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
            System.Console.WriteLine("Criando o diretor");
        }
        public override double getBonificacao()
        {
            return Salario;
        }

        public override void aumentarSalario()
        {
            this.Salario *= 1.15;
        }
    }
}