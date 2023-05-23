using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace N4
{
    public class Calculate
    {
        public static double PI = 3.14;
        public static double Volume(double Radius)
        {
            return 4.0 / 3.0 * PI * Math.Pow(Radius, 3);
        }
        public static double Circumference(double Radius)
        {
            return 2 * PI * Radius;
        }
    }
}