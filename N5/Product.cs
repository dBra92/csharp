using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N5
{
    public class Product
    {
        public string Nome;
        public double Preco;
        public int Quantidade;
        public Product()
        {
        }
        public Product(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //Sobrecarga
        public Product(string name, double preco)
        {
            Nome = name;
            Preco = preco;
            Quantidade = 4;
        }
        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        public override string ToString()
        {
            return $"{Nome}, {Preco}, {Quantidade}, {ValorTotalEmEstoque()}";
        }
    }
}
