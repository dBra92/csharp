using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5._1
{
    public class Product2
    {
        //Formas de usar o this
        //Passar o próprio objeto como argumento na chamada de um método ou construtor
        //
        /*class ChessMatch
        {
            (...)
            PlaceNewPiece('e', 1, new King(board, Color.White, this));
        }*/
        
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Product2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public Product2(int quantidade)
        {
            Quantidade = 10;
        }
        public Product2(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }
    }
}