using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.Entities.BankAccount
{
    public class SavingsAccount: BankAccount
    {
        public SavingsAccount(int ıd, string accountHolder, double balance) : base(ıd, accountHolder, balance)
        {
        }

        public override double CalculateInterest()
        {
            return Balance * 0.05;
        }
    }
}
