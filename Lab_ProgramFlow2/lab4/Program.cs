using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int INumber, ISum = 0;

            Console.Write("number: ");
            INumber = int.Parse(Console.ReadLine());
            while (INumber > 0)
            {
                switch (INumber % 2)
                {
                    case (0):
                        Console.WriteLine("Adding " + INumber);
                        ISum += INumber;
                        break;
                    default:
                        Console.WriteLine("Not adding " + INumber);
                        break;
                }
                INumber--;

            }
            Console.WriteLine("Your total is " + ISum);
            Console.ReadLine();
        }
    }
}
