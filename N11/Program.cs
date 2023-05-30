namespace N11;

class Program
{
    static void Main(string[] args)
    {
        //Matrizes
        
        double [,] matrizes = new double[3,3];

        System.Console.WriteLine($"Lenght:{matrizes.Length}");
        System.Console.WriteLine($"Rank:{matrizes.Rank}"); //Dimensão | Qtd de linhas

        System.Console.WriteLine($"GetLenght:{matrizes.GetLength(0)}"); //1 tamanho 3 | Qtd de linha da matriz
   
            }
}
