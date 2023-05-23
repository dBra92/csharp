using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc9
{
    public class Rectangle
    {
        public double Width;
        public double Height;

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return (Width + Height) * 2;
        }

        public double Diagonal()
        {
            return Math.Sqrt(Width * Width + Height * Height);
        }

        public override string ToString()
        {
            return $"Area = {Area():F2}, Perimeter = {Perimeter():F2}, Diagonal = {Diagonal():F2}";
        }
    }
}