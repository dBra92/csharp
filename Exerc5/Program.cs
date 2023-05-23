using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            Console.WriteLine("ex.5:");
            Console.WriteLine("Pieces 1");
            int code1 = int.Parse(Console.ReadLine());
            int qttOfPieces1 = int.Parse(Console.ReadLine());
            double valueOfPiece1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calc1 = valueOfPiece1 * qttOfPieces1;

            Console.WriteLine("Pieces 2");
            int code2 = int.Parse(Console.ReadLine());
            int qttOfPieces2 = int.Parse(Console.ReadLine());
            double valueOfPieces2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double calc2 = valueOfPieces2 * qttOfPieces2;

            double calc3 = calc1 + calc2;
            Console.WriteLine("Total to pay $" + calc3.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}