using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            int iNumbers = 0;

            int[] arrNumbers = new int[5];
            int[] arrReverse = new int[5];

            do
            {
                Console.Write("Enter a Number:");
                arrNumbers[iNumbers] = int.Parse(Console.ReadLine());
                iNumbers++;
            } while (iNumbers < 5);

            foreach (var item in arrNumbers)
                Console.Write(item.ToString());

            Console.WriteLine();
         
            int k = 0;
            for (int i = 4; i >= 0; i--)
            {
                arrReverse[k] = arrNumbers[i];
                Console.Write(arrReverse[k].ToString());
                k++;
            }
            AnyKey();
        }

        private static void AnyKey()
        {
            Console.Write("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
