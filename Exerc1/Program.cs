using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.1:");
            
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            int sum = number1 + number2;

            Console.WriteLine(sum);
        }
    }
}