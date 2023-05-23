using Exerc8;
using System.Globalization;

namespace Exerc8;
class Program
{
    static void Main(string[] args)
    {
        Employee emp = new Employee();
        Employee emp2 = new Employee();

        System.Console.WriteLine("Data of the first employee:");
        System.Console.Write("Name:");
        emp.name = Console.ReadLine();
        System.Console.Write("Salary $");
        emp.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine("Data of the second employee:");
        System.Console.Write("Name:");
        emp2.name = Console.ReadLine();
        System.Console.Write("Salary $");
        emp2.salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double total = (emp.salary + emp2.salary) / 2.0;

        System.Console.WriteLine($"Avg = {total}");
    }
}
