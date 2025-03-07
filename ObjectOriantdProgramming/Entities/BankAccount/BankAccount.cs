using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOriantdProgramming.Entities.BankAccount
{
    public class BankAccount
    {
        public BankAccount(int ıd, string accountHolder, double balance)
        {
            Id = ıd;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        public int Id { get; set; }
        public string AccountHolder { get; set; }
        public double Balance { get; set; }

        public virtual double CalculateInterest()
        {
            throw new BusinessException("Bank account does not have interest");
        }
        
    }
}
