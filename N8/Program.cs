using System.Collections.Generic;

namespace N8;

class Program
{
    static void Main(string[] args)
    {
        List<string> str = new List<string>();

        str.Add("Keanu");
        str.Add("John");
        str.Add("Ryan");
        str.Add("Hugh");
        str.Add("Vivian");
        str.Add("Orlando");
        str.Add("Gwen");
        str.Add("Marian");
        str.Add("Jackeline");
        str.Add("Helen");
        str.Add("Jack");
        str.Add("Bob");
        str.Add("Leo");

        foreach (string str2 in str)
        {
            System.Console.WriteLine(str2);
        }

        System.Console.WriteLine("------");

        System.Console.WriteLine($"Count:{str.Count}");
        string st1 = str.Find(x => x[0] == 'J');
        System.Console.WriteLine($"Find:{st1}");
        string st2 = str.FindLast(y => y[0] == 'n');
        System.Console.WriteLine($"FindLast:{st2}");
        int st3 = str.FindIndex(z => z[0] == 'V');
        System.Console.WriteLine($"FindIndex:{st3}");
        int st4 = str.FindLastIndex(a => a[0] == 'K');
        System.Console.WriteLine($"FindLastIndex:{st4}");
        List<string> st5 = str.FindAll(b => b.Length == 7);
        foreach (string st51 in st5)
        {
            System.Console.WriteLine($"FindAll:{st51}");
        }
        System.Console.WriteLine("------------Pt2-----------");
        //Parte 2
        System.Console.WriteLine("---Remove");
        str.Remove("Bob");
        foreach(string str2 in str)
        {
            System.Console.WriteLine(str2);
        }
        System.Console.WriteLine("---RemoveAll");
        str.RemoveAll(c => c[0] == 'J');
        foreach(string str2 in str)
        {
            System.Console.WriteLine(str2);
        }
    }
}
