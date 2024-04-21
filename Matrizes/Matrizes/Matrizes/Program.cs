double[,] mat = new double[2, 3];

//Informa quanos elementos existe na matriz
Console.WriteLine(mat.Length);

//Informa quantas linhas existem na matriz
Console.WriteLine(mat.Rank);

//Informa a quantidade de colunas/linhas da matriz apenas utilizar 0 para pegar a primeira dimensão e 1 paraa segunda dimensão
Console.WriteLine(mat.GetLength(0));


//Exercicio:

int n = int.Parse(Console.ReadLine());

int[,] matriz = new int[n, n];

//O primeiro for irá percorrer as linhas
for (int i = 0; i < n; i++)
{
    //Split para você adicionar os 3 valores de cada linha
    string[] valores = Console.ReadLine().Split(' ');

    //Segundo for percorre as colunas
    for (int j = 0; j < n; j++)
    {
        matriz[i, j] = int.Parse(valores[j]);
    }
}

//Mostrar a diagonal principal
Console.WriteLine("Diagonal principal");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(mat[i, i] + " ");
}

var count = 0;
//Numeros negativos na matriz
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        if (mat[i, j] < 0)
        {
            count++;
        }
    }
}
Console.WriteLine("Numeros negativos: " +  count);