using Pdct;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Product pd = new Product();

        System.Console.WriteLine("Entre com os dados do produto:");
        System.Console.Write("Nome:");
        pd.Name = Console.ReadLine();

        System.Console.Write("Preço $");
        pd.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.Write("Quantidade:");
        pd.Quantitie = int.Parse(Console.ReadLine());

        System.Console.WriteLine(pd);

        System.Console.Write("Digite o número de produtos a ser adicionado ao estoque:");
        int Quantitie = int.Parse(Console.ReadLine());
        pd.AddProducts(Quantitie);
        System.Console.WriteLine(pd);

        System.Console.Write("Digite o número de produtos a ser removido do estoque:");
        Quantitie = int.Parse(Console.ReadLine());
        pd.RmvProducts(Quantitie);
        System.Console.WriteLine(pd);

    }
}
