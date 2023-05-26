namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        private double _saldo;

        public Conta(int numeroConta, string nomeTitular, double saldo)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            _saldo = saldo;
        }

        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        public void Saque(double valor)
        {
            _saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: ${_saldo}";
        }
    }
}
