namespace N5;
class Program
{
    static void Main(string[] args)
    {
        Product pd3 = new Product()
        {
            Nome = "Tv",
            Preco = 900.0,
            Quantidade = 10
        };
        System.Console.WriteLine(pd3);
        /*
        System.Console.WriteLine("Entre com os dados do produto:");
        System.Console.Write("Nome do produto:");
        string name = Console.ReadLine();

        System.Console.Write("Preço $");
        double preco = double.Parse(Console.ReadLine());

        // Sobrecarga
        Product pd2 = new Product(name, preco);
        System.Console.WriteLine(pd2);

        System.Console.Write("Quantidade:");
        int quantidade = int.Parse(Console.ReadLine());

        Product pd = new Product(name, preco, quantidade);

        Console.WriteLine("Dados do produto: " + pd);

        Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
        int qte = int.Parse(Console.ReadLine());
        pd.AdicionarProdutos(qte);
        Console.WriteLine("Dados atualizados: " + pd);

        Console.Write("Digite o número de produtos a ser removido do estoque: ");
        qte = int.Parse(Console.ReadLine());
        pd.RemoverProdutos(qte);
        Console.WriteLine("Dados atualizados: " + pd);*/
    }
}
