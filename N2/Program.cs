using Function;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle x = new Triangle();
            Triangle y = new Triangle();

            x.number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.number3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.number3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double result1 = x.Area();
            double result2 = y.Area();

            System.Console.WriteLine($"R1 = {result1:F3}");
            System.Console.WriteLine($"R2 = {result2:F3}");
        }
    }
}