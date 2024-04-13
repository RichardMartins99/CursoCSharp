var list = new List<string>();

//Add serve para adicionar o objeto ao final da lista
list.Add("Maria");
list.Add("Alex");
list.Add("Bob");
list.Add("Ana");

//Insert serve para adicionar em um determinado local o objeto
list.Insert(2, "Marco");

foreach (var item in list)
{
    Console.WriteLine(item);
}

//Count serve para contar os elementos totais na lista
Console.WriteLine(list.Count());

//Find encontra o primeiro elemento da lista que satisfaça o predicado
string s1 = list.Find(x => x[0] == 'A');
Console.WriteLine("First A: " + s1);

//FindLast encontra o primeiro elemento da lista que satisfaça o predicado
string s2 = list.FindLast(x => x[0] == 'A');
Console.WriteLine("Last A: " + s2);

//FindIndex busca a primeira posição do elemento adicionado no predicado
int pos1 = list.FindIndex(x => x[0] ==  'A');
Console.WriteLine("First position:" + pos1);

//FindLastIndex busca a ultima posição do elemento adicionado no predicado
int pos2 = list.FindLastIndex(x => x[0] == 'A');
Console.WriteLine("Last position:" + pos2);

//FindAll adicionado um filtro na lista e criando uma nova lista de elementos que satisfaça o predicado
List<string> list2 = list.FindAll(x => x.Length == 5);
foreach (var item in list2)
{
    Console.WriteLine(item);
}

//Remove um elemento especifico
list.Remove("Alex");

//Remove apartir de uma determinada posição e quantas posições remover
list.RemoveRange(2, 2);

//Remove o elemento que adicionar no predicado
list.RemoveAll(x => x[0] == 'M');

//Remove um elemento especifico de uma posição
list.RemoveAt(2);