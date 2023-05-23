using Exerc11;
using System.Globalization;

namespace Exerc11;
class Program
{
    static void Main(string[] args)
    {

        Student std = new Student();
        System.Console.Write("Student name:");
        std.name = Console.ReadLine();

        System.Console.Write("Enter with of three student grade:");
        std.grade1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        std.grade2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        std.grade3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        System.Console.WriteLine($"Final Grade:{std.Calc()}");

        if (std.Approved())
        {
            System.Console.WriteLine("Approved");
        }
        else
        {
            System.Console.WriteLine("Disapproved");
            System.Console.WriteLine($"Need {std.RemainingGrade()}");
        }
    }
}
