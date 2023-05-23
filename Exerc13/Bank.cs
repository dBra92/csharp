using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exerc13
{
    public class Bank
    {
        public int Account { get; private set; } //Numero da conta nao vai ser alterado
        public string Name { get; set; }
        public double Balance { get; private set; }

        public Bank(int account, string name, double balance)
        {
            Account = account;
            Name = name;
            Balance = balance;
        }

        public Bank(int account, string name)
        {
            Account = account;
            Name = name;
        }

        public void AddDeposit(double deposit)
        {
            Balance += deposit;
        }
        public void RmvDeposit(double withdraw)
        {
            Balance -= withdraw + 5;
        }
        public override string ToString()
        {
            return $"{Account}, {Name}, {Balance}";
        }
    }
}