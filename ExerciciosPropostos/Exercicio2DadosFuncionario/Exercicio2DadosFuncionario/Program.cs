using Exercicio2DadosFuncionario;
using System.Globalization;

var funcionario = new Funcionario();

Console.Write("Nome: ");
funcionario.Nome = Console.ReadLine();

Console.Write("Salário bruto: ");
funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Imposto: ");
funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Funcionário: {funcionario.Nome}, {funcionario.SalarioLiquido():F2}");
Console.Write($"Digite a porcentagem para aumentar o salário: ");
funcionario.AumentarSalario(double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

Console.WriteLine($"Dados atualizados: {funcionario.Nome}, {funcionario.SalarioLiquido():F2}");