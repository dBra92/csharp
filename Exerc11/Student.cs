using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc11
{
    public class Student
    {
        public string name;
        public double grade1;
        public double grade2;
        public double grade3;

        public double Calc()
        {
            return grade1 + grade2 + grade3;
        }

        public bool Approved()
        {
            if (Calc() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingGrade()
        {
            if (Approved())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - Calc();
            }
        }
    }
}