using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Price, Paid, Change;

            Console.Write("Price: ");
            Price = int.Parse(Console.ReadLine());
            Console.Write("Paid: ");
            Paid = int.Parse(Console.ReadLine());

            Change = Paid - Price;
            Console.Write("Your change is {0}: ", Change);

            Change = CalcChange(Change);
            AnyKey();
        }

        private static int CalcChange(int change)
        {
            while (change > 0)
            {
                if (change >= 50)
                {
                    Console.Write("50 ");
                    change -= 50;
                }
                else
                {
                    if (change >= 20)
                    {
                        Console.Write("20 ");
                        change -= 20;
                    }
                    else
                    {
                        if (change >= 10)
                        {
                            Console.Write("10 ");
                            change -= 10;
                        }
                        else
                        {
                            if (change >= 5)
                            {
                                Console.Write("5 ");
                                change -= 5;
                            }
                            else
                            {
                                if (change >= 2)
                                {
                                    Console.Write("2 ");
                                    change -= 2;
                                }
                                else
                                {
                                    Console.Write("1 ");
                                    change -= 1;
                                }
                            }
                        }
                    }
                }
            }

            return change;
        }

        private static void AnyKey()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
