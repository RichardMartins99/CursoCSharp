Console.WriteLine("Quantas linhas terá a matriz? ");
var linha = int.Parse(Console.ReadLine());

Console.WriteLine("Quantas colunas terá a matriz? ");
var coluna = int.Parse(Console.ReadLine());

int[,] matriz = new int[linha, coluna];

for (int i = 0; i < linha; i++)
{
    var stringValores = Console.ReadLine().Split(' ');
    for (int j = 0; j < coluna; j++)
    {
        matriz[i, j] = int.Parse(stringValores[j]);
    }
}

Console.WriteLine("Qual valor você quer saber? ");
var valor = int.Parse(Console.ReadLine());

for (int i = 0; i < linha; i++)
{
    for (int j = 0; j < coluna; j++)
    {
        if (matriz[i, j] == valor)
        {
            Console.WriteLine("Posição " + i + "," + j + ":");
            if (j > 0)
            {
                Console.WriteLine("Esquerda: " + matriz[i, j - 1]);
            }
            if (i > 0)
            {
                Console.WriteLine("Cima: " + matriz[i - 1, j]);
            }
            if (j < coluna - 1)
            {
                Console.WriteLine("Direita: " + matriz[i, j + 1]);
            }
            if (i < coluna - 1)
            {
                Console.WriteLine("Baixo: " + matriz[i + 1, j]);
            }
        }
    }
}