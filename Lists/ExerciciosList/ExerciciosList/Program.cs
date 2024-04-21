
using ExerciciosList;

Console.WriteLine("Quantos registros de funcionários você quer adicionar? ");
var numeroRegistros = int.Parse(Console.ReadLine());

var listFuncionarios = new List<Funcionario>();
for (int i = 0; i < numeroRegistros; i++)
{
    Console.WriteLine("Qual id do funcionário? ");
    var id = int.Parse(Console.ReadLine());

    if (listFuncionarios.Any(x => x.Id == id))
    {
        Console.WriteLine("Este Id já existe em outro funcionário!");

        Console.WriteLine("Digite o id do funcionário: ");
        id = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Qual nome do funcionário? ");
    var nome = Console.ReadLine();

    Console.WriteLine("Qual salário do funcionário? ");
    double salario = double.Parse(Console.ReadLine());

    var funcionario = new Funcionario(id, nome, salario);
    listFuncionarios.Add(funcionario);
}

Console.WriteLine("     ");
Console.WriteLine("Agora digite o id do funcionário que você quer aumentar o salário: ");
var idFuncionarioAumentoSalario = int.Parse(Console.ReadLine());

Console.WriteLine("Agora digite o aumento do salário: ");
var aumento = double.Parse(Console.ReadLine());

var funcionarioAumento = listFuncionarios.Find(x => x.Id == idFuncionarioAumentoSalario);

if (funcionarioAumento is null)
{
    Console.WriteLine("Nao existe este funcionario!");
}
else
{
    funcionarioAumento.AumentarSalario(aumento);

    listFuncionarios.RemoveAll(x => x.Id == idFuncionarioAumentoSalario);
    listFuncionarios.Add(funcionarioAumento);
}

foreach (var item in listFuncionarios)
{
    Console.WriteLine("Id: " + item.Id);
    Console.WriteLine("Nome: " + item.Nome);
    Console.WriteLine("Salario: " + item.Salario);
}
