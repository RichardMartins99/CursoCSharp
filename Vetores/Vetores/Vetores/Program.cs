
// 1° exercicio____________________

using System.Globalization;
using Vetores;

int n = int.Parse(Console.ReadLine());

double[] vec = new double[n];

for (int i = 0; i < n; i++)
{
    vec[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}

double sum = 0.0;

for (int i = 0;i < n; i++)
{
    sum += vec[i];
}

double avg = sum / n;

Console.WriteLine("Medias: " + avg);

// 2° exercicio________________

int numero = int.Parse(Console.ReadLine());

Produto[] produtoVetor = new Produto[numero];

for (int i = 0; i < numero ; i++)
{
    string nome = Console.ReadLine();
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    produtoVetor[i] = new Produto { Nome = nome, Preco = price };
}

double soma = 0.0;

for (int i = 0; i < numero; i++)
{
    soma += produtoVetor[i].Preco;
}

double media = soma / numero;

Console.WriteLine("Preco medio: " + media);