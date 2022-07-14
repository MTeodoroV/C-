using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkBank_ADM.Funcionarios
{
    public abstract class Funcionario
    {
        // 0 - funcionario
        // 1 - diretor
        // 2 - designer

        //private int _tipo;
        public string Nome { get; set; }

        public string Cpf { get; private set; }

        public double Salario { get; protected set; }


        public static int totalDeFuncionarios { get; private set; }

        public Funcionario(string cpf, double salario)
        {
            this.Cpf = cpf;
            this.Salario = salario;
            totalDeFuncionarios++;
        }
        public abstract double getBonificacao();

        public abstract void aumentarSalario();
    }
}