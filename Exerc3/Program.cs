using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.3:");
            int value1 = int.Parse(Console.ReadLine());
            int value2 = int.Parse(Console.ReadLine());
            int value3 = int.Parse(Console.ReadLine());
            int value4 = int.Parse(Console.ReadLine());

            int difference = (value1 * value2 - value3 * value4);

            Console.WriteLine("Difference = " + difference);
        }
    }
}