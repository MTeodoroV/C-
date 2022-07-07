using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using checkBank_ADM.Funcionarios;

namespace checkBank_ADM.Utils
{
    public class GerenciadorDeBonificacao
    {
        private double totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this.totalBonificacao += funcionario.getBonificacao();
        }

        public void Registrar(Diretor diretor)
        {
            this.totalBonificacao += diretor.getBonificacao();
        }

        // Sobrecarga de métodos, é o mesmo método que vai receber parâmetros diferentes.
        public double getBonificacao()
        {
            return this.totalBonificacao;
        }
    }
}