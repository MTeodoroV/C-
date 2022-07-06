using checkBank;
using checkBank.Titular;

namespace checkBank
{
    public class contaCorrente
    {
        public Cliente titular;
        public string conta;
        public int agencia;
        public string nome_agencia;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (saldo < valor || valor < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                return true;
            }
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            saldo = saldo + valor;
        }

        public bool Transferir(double valor, contaCorrente destino)
        {
            if (saldo < valor || saldo < 0){
                return false;
            }
            else {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }
    }
}