using ContaBancaria;

Console.WriteLine("Adicione o número da conta: ");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("Adicione o nome do titular da conta: ");
string nome = Console.ReadLine();

Console.WriteLine("Haverá depósito inicial (s/n)?");
string isDepositoInicial = Console.ReadLine();

double deposito = 0;
if (isDepositoInicial == "s")
{
    Console.WriteLine("Entre com valor de depósito inicial: ");
    deposito = double.Parse(Console.ReadLine());
}

var conta = new Conta(numero, nome, deposito);

Console.WriteLine("Dados da conta: ");
Console.WriteLine(conta);

Console.WriteLine("Entre um valor para depósito: ");
conta.Depositar(double.Parse(Console.ReadLine()));

Console.WriteLine("Dados da conta atualizado: ");
Console.WriteLine(conta);

Console.WriteLine("Entre com um valor para saque: ");
conta.Saque(double.Parse(Console.ReadLine()));
Console.WriteLine("Dados da conta atualizados: ");
Console.WriteLine(conta);
