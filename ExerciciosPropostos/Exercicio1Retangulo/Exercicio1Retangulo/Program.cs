using Exercicio1Retangulo;
using System.Globalization;

Console.WriteLine("Entre com a largura e altura do retangulo: ");
Console.Write("Largura: ");
var retangulo = new Retangulo();

retangulo.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Altura: ");
retangulo.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine($"Area: { retangulo.Area():F2}");
Console.WriteLine($"Perímetro: {retangulo.Perimetro():F2}");
Console.WriteLine($"Diagonal: {retangulo.Diagonal():F2}");