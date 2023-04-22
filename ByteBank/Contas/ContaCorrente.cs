using bytebank.Titular;

namespace bytebank.Contas
{
    public class ContaCorrente
    {
        // Campos da class
        private int numero_agencia;
        public int Numero_agencia
        {
            get { return this.numero_agencia; }
            set
            {
                if (value > 0)
                {
                    this.numero_agencia = value;
                }
            }
        }
        public string Conta { get; set; }
        private double saldo = 100;
        public Cliente Titular { get; set; }


        //Funções da class ContaCorrente
        public void Depositar(double valor)
        {
            saldo += valor;
        }
        public bool Sacar(double valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool Transferir(double valor, ContaCorrente destino)
        {
            if (saldo < valor)
            {
                return false;
            }
            else
            {
                Sacar(valor);
                destino.Depositar(valor);
                return true;
            }
        }
        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                return;
            }
            else
            {
                this.saldo = valor;
            }
        }
        public double GetSaldo()
        {
            return this.saldo;
        }

    }
}