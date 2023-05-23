using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pdct
{
    public class Product
    {
        public string Name;
        public double Price;
        public int Quantitie;

        public double ValueTotalInStock()
        {
            return Quantitie * Price;
        }

        public void AddProducts(int Quantitie)
        {
            this.Quantitie += Quantitie;
        }

        public void RmvProducts(int Quantitie)
        {
            this.Quantitie -= Quantitie;
        }

        public override string ToString()
        {
            return $"{Name}, {Price}, {Quantitie}, Total ${ValueTotalInStock()}";
        }
    }
}