using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc10
{
    public class Employee2
    {
        public string Name;
        public double GrossSalary;
        public double Tax;

        public double LiquidSalary()
        {
            return GrossSalary - Tax;
        }

        public void IncreaseSalary(double Percentage)
        {
            GrossSalary = GrossSalary + (GrossSalary * Percentage / 100.0);
        }

        public override string ToString()
        {
            return $"{Name}, Liquid Salary$ {LiquidSalary()}";
        }
    }
}