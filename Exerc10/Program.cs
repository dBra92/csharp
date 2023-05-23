using Exerc10;
using System.Globalization;

namespace Exerc10;
class Program
{
    static void Main(string[] args)
    {
        Employee2 emp2 = new Employee2();
        System.Console.Write("Name:");
        emp2.Name = Console.ReadLine();

        System.Console.Write("Gross salary $");
        emp2.GrossSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.Write("Tax $");
        emp2.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine($"Employee - {emp2}");

        System.Console.Write("Enter a percentage to increase salary:");
        double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        emp2.IncreaseSalary(percentage);

        System.Console.WriteLine($"Employee - {emp2}");
    }
}
