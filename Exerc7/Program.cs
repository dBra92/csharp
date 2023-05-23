using Exerc7;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person prs = new Person();
            Person prs2 = new Person();

            System.Console.WriteLine("Data of the first person:");
            System.Console.Write("Name:");
            prs.name = Console.ReadLine();

            System.Console.Write("Age:");
            prs.age = int.Parse(Console.ReadLine());

            System.Console.WriteLine();

            System.Console.WriteLine("Data of the second person:");
            System.Console.Write("Name:");
            prs2.name = Console.ReadLine();

            System.Console.Write("Age:");
            prs2.age = int.Parse(Console.ReadLine());

            if (prs.age > prs2.age)
            {
                System.Console.WriteLine($"The oldest person is {prs.name}");
            }
            else if (prs2.age > prs.age)
            {
                System.Console.WriteLine($"The oldest person is {prs2.name}");
            }
            else if (prs.age == prs2.age)
            {
                System.Console.WriteLine("People are the same age");
            }

        }
    }
}