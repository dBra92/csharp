using N4;
using System.Globalization;
namespace N4;
class Program
{
    static void Main(string[] args)
    {

        System.Console.Write("Entre com o valor do raio:");
        double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double circumference = Calculate.Circumference(radius);
        double volume = Calculate.Volume(radius);
        System.Console.WriteLine($"Circ.:{circumference}");
        System.Console.WriteLine($"Vol.:{volume:F2}");
        System.Console.WriteLine($"PI:{Calculate.PI}");
    }

}
