using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc12
{
    public class ConvertCoin
    {
        public static double IOF=6.00;

        public static double CDolarEmReal(double cotacaoDolar, double compraReal)
        {
            double total = cotacaoDolar * compraReal;
            return total + total * IOF / 100.0;
        }

   }
}