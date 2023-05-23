
namespace N7;

class Program
{
    static void Main(string[] args)
    {
        Point point;
        point.X = 880;
        point.Y = 50;

        System.Console.WriteLine(point);

        point  = new Point();
        System.Console.WriteLine(point);
    }
}
