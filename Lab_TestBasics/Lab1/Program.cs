using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
        
                //Console.Write("Distance (m):");
                //int iMeters = int.Parse(Console.ReadLine());
                //Console.Write("Time (H):");
                //double dHours = Convert.ToSingle(Console.ReadLine());
                ////double dHours = double.Parse(Console.ReadLine());
                //Console.Write("Time (M):");
                //double dMin = Convert.ToSingle(Console.ReadLine());
                //Console.Write("Time (S):");
                //double dSeconds = Convert.ToSingle(Console.ReadLine());

                //CalcSpeed(iMeters, dHours, dMin, dSeconds);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            AnyKey();
        }

        private void GetInput()
        {
            int iMeters;
            bool isMeter;

            //      int iMeters = int.Parse(Console.ReadLine());

            do
            {
                Console.Write("Distance (m):");
                isMeter = int.TryParse(Console.ReadLine(), out iMeters);
            } while (!isMeter);
            Console.Write("Time (H):");
            double dHours = Convert.ToSingle(Console.ReadLine());
            //double dHours = double.Parse(Console.ReadLine());
            Console.Write("Time (M):");
            double dMin = Convert.ToSingle(Console.ReadLine());
            Console.Write("Time (S):");
            double dSeconds = Convert.ToSingle(Console.ReadLine());
        }

        private static void AnyKey()
        {
            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }

        private static void CalcSpeed(int iDistance, double dHours, double dMin, double dSeconds)
        {
            double time = (dHours * 3600) + (dMin * 60) + dSeconds;
            double mps = iDistance / time;
            double kph = (iDistance / 1000.0) / (time / 3600.0);
            double mph = kph / 1.609;

            Console.WriteLine("Speed m/s: " + mps.ToString());
            Console.WriteLine("Speed km/h: " + kph.ToString());
            Console.WriteLine("Speed m/h: " + mph.ToString("F1"));
        }
    }
}







//private static void Fib()
//{
//    int i = 1, j = 1, val;
//    while (i < 25)
//    {
//        Console.Write(j + " ");
//        val = i + j;
//        j = i;
//        i = val;
//    }
//}