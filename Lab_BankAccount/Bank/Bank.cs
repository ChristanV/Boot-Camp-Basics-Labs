using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private static int NumberOfAccounts = 0;
        int AccountNumber;
        decimal Balance;
        decimal Over;

        public BankAccount():this(0,0)
        {

        }
        public BankAccount(decimal accBalance, decimal accOverdraft)
        {
            AccountNumber = ++NumberOfAccounts;
            this.Balance = accBalance;
            this.Over = accOverdraft;
        }

        public void Deposit(decimal Amount)
        {
            if (Amount > 0)
                Balance += Amount;
        }

        public void WithDraw(decimal Amount)
        {
            if (Amount > 0)
            {
                decimal NewBalance = Balance - Amount;
             //   if (NewBalance >= 0)
                    Balance = NewBalance;
            }
        }

        public void Details()
        {
            Console.WriteLine("Details");

            Console.WriteLine("Balance: " + this.Balance.ToString("C1"));
            Console.WriteLine("Overload: " + this.Over.ToString("C1"));
            Console.WriteLine();
        }

    }
}
