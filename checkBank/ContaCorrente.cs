using checkBank;
using checkBank.Titular;

namespace checkBank
{
    public class contaCorrente
    {
        public Cliente Titular { get; set; }
        private string _conta;
        public string Conta
        {
            get
            {
                return Conta;
            }
            set
            {
                if (value == null)
                {
                    return;
                }
                else
                {
                    _conta = value;
                }
            }
        }


        private int _numero_agencia;
        public int Numero_agencia
        {
            get
            {
                return _numero_agencia;
            }
            set
            {
                if (value <= 0)
                {

                }
                else
                {
                    _numero_agencia = value;
                }
            }
        }

        public string nome_agencia { get; set; }
        private double saldo;

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
            if (saldo < valor || saldo < 0)
            {
                return false;
            }
            else
            {
                saldo = saldo - valor;
                destino.saldo = destino.saldo + valor;
                return true;
            }
        }

        // public void SetSaldo(double valor)
        // {
        //     if (valor < 0)
        //     {
        //         return;
        //     }
        //     saldo = valor;
        // }

        // public double GetSaldo()
        // {
        //     return saldo;
        // }

        public double Saldo
        {
            get
            {
                return saldo;
            }

            set
            {
                if (value < 0)
                {
                    return;
                }
                saldo = value;
            }
        }
    
        public contaCorrente(int _agencia, string conta)
        {
            Numero_agencia = _numero_agencia;
            Conta = conta;
            TotalDeContasCriadas += 1;
        }

        public static int TotalDeContasCriadas {get; set;}
    }
}