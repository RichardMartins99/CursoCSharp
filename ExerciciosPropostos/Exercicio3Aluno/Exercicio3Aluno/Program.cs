using Exercicio3Aluno;
using System.Globalization;

var aluno = new Aluno();
Console.Write("Nome do Aluno: ");
aluno.Nome = Console.ReadLine();

Console.WriteLine("Digite as 3 notas do aluno: ");
Console.Write("Digite a primeira nota: ");
aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a segunda nota: ");
aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Digite a terceira nota: ");
aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Nota Final: " + aluno.SomadorDeNotas());
Console.WriteLine(aluno.ResultadoNotas());