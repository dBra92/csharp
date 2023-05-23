using Exerc13;

namespace Exerc13;
class Program
{
    static void Main(string[] args)
    {
        Bank bk;

        System.Console.Write("Entre com o nº da conta:");
        int account = int.Parse(Console.ReadLine());
        System.Console.Write("Entre com o titular da conta:");
        string name = Console.ReadLine();
        System.Console.Write("Haverá deposito inicial[S/N]:");
        string question = Console.ReadLine();


        if (question.Equals("S") || question.Equals("s"))
        {

            System.Console.Write("Entre com o valor do deposito inicial:");
            double initialDeposit = double.Parse(Console.ReadLine());

            bk = new Bank(account, name, initialDeposit);
            System.Console.WriteLine(bk);
        }
        else
        {
            bk = new Bank(account, name);
        }

        System.Console.Write("Entre com um valor de deposito:");
        double balance = double.Parse(Console.ReadLine());
        bk.AddDeposit(balance);

        System.Console.WriteLine(bk);

        System.Console.Write("Entre com o valor do saque $");
        double withdraw = double.Parse(Console.ReadLine());
        bk.RmvDeposit(withdraw);

        System.Console.WriteLine("Dados atualizados:");
        System.Console.WriteLine(bk);
    }
}
