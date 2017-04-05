using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount b1 = new BankAccount();
            BankAccount b2 = new BankAccount(1000, 200);
            BankAccount s; s = new BankAccount();
            b1.Deposit(200);
            b2.WithDraw(50);

            b1.Details();
            b2.Details();
            Console.ReadKey();
        }

        }
    }

