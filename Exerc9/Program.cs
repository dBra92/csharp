using Exerc9;
using System.Globalization;

namespace Exerc9;
class Program
{
    static void Main(string[] args)
    {
        Rectangle rt = new Rectangle();
        System.Console.WriteLine("Entre com a largura e altura do retângulo:");
        rt.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        rt.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine(rt);
    }
}
