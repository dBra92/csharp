using System;
using System.Globalization;

namespace Begin
{
    public class Program
    {
        static void Main(string[] args) // Entrepoint
        {
            sbyte sb = 3; // Ou SByte
            short sh = -89;
            int inter = -100;
            long longer = -1000;
            byte bt = 126; //so positivo
            ushort ush = 89;
            uint inter2 = 100;
            ulong longer2 = 1000;
            float flo = 1.0f;
            double doub = 1.0;
            decimal dec = 1; // Calc financeiro
            char ch = 'A';
            bool bo = true;
            string str = "Blz";
            object obj = "Ok";

            Console.WriteLine("sb " + sb);
            Console.WriteLine(" sh" + sh);
            Console.WriteLine(" inter" + inter);
            Console.WriteLine(" longer" + longer);
            Console.WriteLine("bt " + bt);
            Console.WriteLine("ush " + ush);
            Console.WriteLine(" inter2" + inter2);
            Console.WriteLine("longer2 " + longer2);
            Console.WriteLine(" flo" + flo);
            Console.WriteLine("doub " + doub);
            Console.WriteLine("dec " + dec);
            Console.WriteLine(" ch" + ch);
            Console.WriteLine(" bo" + bo);
            Console.WriteLine("str " + str);
            Console.WriteLine("obj " + obj);
            int number1 = int.MinValue;
            int number2 = int.MaxValue;
            sbyte number3 = sbyte.MaxValue;
            sbyte number4 = sbyte.MinValue;
            decimal number5 = decimal.MinValue;

            Console.WriteLine("n1 " + number1);
            Console.WriteLine("n2 " + number2);
            Console.WriteLine("n3 " + number3);
            Console.WriteLine("n4 " + number4);
            Console.WriteLine("n5 " + number5);
            //ex1.:
            double a = 5.1;
            float b = (float)a;

            //ex2.:
            double c = 7.2;
            int d = (int)c;

            //ex3.: 
            int a3 = 3;
            int b3 = 6;
            double calc = (double)a3 / b3;

            string nome = "Leonardo";
            double saldo = 19.910291;
            int idade = 29;

            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Placeholders.");
            Console.WriteLine("{0} tem {1} anos e um saldo de {2:F2}", nome, idade, saldo);
            Console.WriteLine("Interpolação.");
            Console.WriteLine($"{nome} tem {idade} anos e um saldo de {saldo:F2}");
            Console.WriteLine("CultureInfo... só com concatenação, placeholders e interpolação não funfa");

            Console.WriteLine("--------------------------------------------------------------------------");
            Console.WriteLine("Concatenar com string:");
            string abcedario = "ABC";
            abcedario += "GHI";
            Console.WriteLine(abcedario);

            int abc = 10;
            int bcd = ++abc;

            Console.WriteLine(abc);
            Console.WriteLine(bcd);

            Console.WriteLine("Implicita e Casting");
            float fl = 10.1f;
            double db = fl; //Double para float nao ocorrerá pq a ocupação do double é maior que a do float. Double 8 bytes, Float 4 bytes
            Console.WriteLine(db.ToString("F2"));
            //Para perda de informação
            double db2 = 7.12;
            float fl2 = (float)db2;


            Console.WriteLine("Precedência maior: * / %");


            string[] vetor = Console.ReadLine().Split(",");
            Console.WriteLine($"{vetor[0]} \n{vetor[1]} \n{vetor[2]}");

            Console.WriteLine("Operadores comparativos");
            int a4 = 10;
            bool c1 = a4 < 10;
            bool c2 = a4 < 20;
            bool c3 = a4 > 10;
            bool c4 = a4 > 5;
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine("------------");
            bool c5 = a4 <= 10;
            bool c6 = a4 >= 10;
            bool c7 = a4 == 10;
            bool c8 = a4 != 10;
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);

            Console.WriteLine("Operadores logicos");
            bool c9 = 2 > 3 || 4 != 5; // true
            bool c10 = !(2 > 3) && 4 != 5; // true
            Console.WriteLine(c9);
            Console.WriteLine(c10);
            Console.WriteLine("--------------");
            bool c11 = 10 < 5; // false
            bool c12 = c1 || c2 && c3; // true
            Console.WriteLine(c11);
            Console.WriteLine(c12);

            Console.WriteLine("If's elses:");
            int number10 = 12;
            //Simples
            if (number10 == 12)
            {
                Console.WriteLine($"Number 10 é igual a{number10}");
            }

            //Composta
            Console.WriteLine("Entre com um número inteiro:");
            int x = int.Parse(Console.ReadLine());
            if (x % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Impar");
            }

            // Encadeamentos
            Console.WriteLine("Qual a hora atual?");
            int hora = int.Parse(Console.ReadLine());
            if (hora < 12)
            {
                Console.WriteLine("Bom dia!");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde!");
            }
            else
            {
                Console.WriteLine("Boa noite!");
            }
        }
    }
}
