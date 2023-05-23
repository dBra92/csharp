using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N6
{
    public class Product3
    {
        //get - set; obter - definir. Get/Set não muito usual

        private string _name; //Alterar nivel de acesso do atributo é colocado _ antes da nomeação,Ex.: _nome
        public double Price { get; private set; }
        public int Quantitie { get; private set; }
        public Product3(string name, double price, int quantitie)
        {
            _name = name;
            Price = price;
            Quantitie = quantitie;
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double ValorTotalEmEstoque()
        {
            return Price * Quantitie;
        }

        public void AdicionarProdutos(int quantitie)
        {
            Quantitie += quantitie;
        }

        public void RemoverProdutos(int _quantitie)
        {
            Quantitie -= _quantitie;
        }

        public override string ToString()
        {
            return $"{_name}, {Price}, {Quantitie}, Total:{ValorTotalEmEstoque()}";
        }

    }
}