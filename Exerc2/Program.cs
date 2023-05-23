using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.2:");
            double radius = double.Parse(Console.ReadLine());

            double pi = 3.14159;
            double area = pi * Math.Pow(radius, 2);

            Console.WriteLine("    " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
