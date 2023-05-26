namespace ContaBancaria
{
    class Conta
    {
        public int NumeroConta { get; private set; }
        public string NomeTitular { get; set; }
        public double Saldo { get; private set; };

        public Conta(int numeroConta, string nomeTitular, double deposito)
        {
            NumeroConta = numeroConta;
            NomeTitular = nomeTitular;
            Depositar(deposito);
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
        }

        public void Saque(double valor)
        {
            Saldo -= valor + 5;
        }

        public override string ToString()
        {
            return $"Conta: {NumeroConta}, Titular: {NomeTitular}, Saldo: ${Saldo}";
        }
    }
}
