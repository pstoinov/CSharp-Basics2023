using System;

namespace _01.Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int row = 1, numberToPrint = 1;
            while (numberToPrint <= n) 
            {
                for (int i = 0; i < row; i++)
                {
                    Console.Write($"{numberToPrint} ");
                    numberToPrint++;
                    if (numberToPrint > n)
                    {
                        break;
                    }
                }
                row++;
                Console.WriteLine();
            }


            //int current = 1;
            //bool isBigger = false;
            //for (int rows = 1; rows <= n ; rows++)
            //{
            //    for (int cols = 1; cols <= rows ; cols++)
            //    {
            //        if (current > n)
            //        {
            //            isBigger = true;
            //            break;
            //        }
            //        Console.Write(current + " ");
            //        current++;
            //    }
            //    if (isBigger) { break; }
            //    Console.WriteLine();
            //}
        }
    }
}
