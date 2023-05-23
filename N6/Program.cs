using N6;
namespace N6;
class Program
{
    static void Main(string[] args)
    {
        Product3 pd3 = new Product3("Tv", 900.0, 10);
        
        pd3.Name = "Tv mais de 8k";
        
        System.Console.WriteLine(pd3.Name);
        System.Console.WriteLine(pd3.Price);
        System.Console.WriteLine(pd3.Quantitie);
    }
}
