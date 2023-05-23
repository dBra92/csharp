using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.6:");
            double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double triangle = a * c / 2.0;
            double circle = c * c * 3.14159;
            double trapeze = (a + b) / 2.0 * c;
            double square = b * b;
            double rectangle = a * b;

            Console.WriteLine("T "+triangle);
            Console.WriteLine("C "+circle);
            Console.WriteLine("Trapeze "+trapeze);
            Console.WriteLine("S "+square);
            Console.WriteLine("R"+rectangle);
        }
    }
}