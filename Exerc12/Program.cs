using Exerc12;
using System.Globalization;
namespace Exerc12;
class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Qual cotação do dolar $");
        double cotacaoDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.Write("Quantos dolares irá comprar $");
        double compraDolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = ConvertCoin.CDolarEmReal(cotacaoDolar, compraDolar);
        System.Console.WriteLine($"Valor a ser pago em R${total:F2}");
    }
}
