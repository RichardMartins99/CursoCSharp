using System.Globalization;

namespace ProblemaEstoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto produto = new Produto();

            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade: ");
            produto.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado no estoque: ");
            int qte = int.Parse(Console.ReadLine());
            produto.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + produto);

            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados" + produto);
        }
    }
}