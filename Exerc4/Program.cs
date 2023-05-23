
using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.4:");
            int code = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double salary = double.Parse(Console.ReadLine());

            double total = salary * hours;
            Console.WriteLine($"{code} \n Salary{total}");
        }
    }
}