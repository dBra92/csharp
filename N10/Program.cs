namespace N10;

class Program
{
    static void Main(string[] args)
    {
        int number = 10;


        RefOut.Triple(ref number);
        System.Console.WriteLine(number);
    }
}
