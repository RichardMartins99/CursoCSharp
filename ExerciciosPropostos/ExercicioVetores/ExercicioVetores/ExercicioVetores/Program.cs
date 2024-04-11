using ExercicioVetores;

Console.WriteLine("Quantos quartos vocês quer alugar?");
var n = int.Parse(Console.ReadLine());

Cliente[] vect = new Cliente[10];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Digite o nome do cliente: ");
    string nome = Console.ReadLine();
    
    Console.WriteLine("Digite o e-mail do cliente: ");
    string email = Console.ReadLine();
    
    Console.WriteLine("Digite o quarto do cliente: ");
    int quarto = int.Parse(Console.ReadLine());

    vect[quarto] = new Cliente() { Nome = nome, Email = email, Quarto = quarto };
}

Console.WriteLine(" ");
Console.WriteLine("Relatorio de todos os quartos em ordem de quarto");

foreach (var item in vect)
{
    if (item is not null)
    {
        Console.WriteLine("Quarto: " + item.Quarto);
        Console.WriteLine("Nome: " + item.Nome);
        Console.WriteLine("E-mail: " + item.Email);
    }
}





