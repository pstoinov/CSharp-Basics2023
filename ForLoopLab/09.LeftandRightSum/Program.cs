using System;
using System.Security.Cryptography;

namespace _09.LeftandRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumLeft = 0;
            int sumRight = 0;
            for (int i = 1; i <= n; i++)
            {
                int numLeft = int.Parse(Console.ReadLine());
                sumLeft += numLeft;
                
            }
            for (int i = 1; i <= n; i++)
            {
                int numRight = int.Parse(Console.ReadLine());
                sumRight += numRight;
            }
            if (sumLeft == sumRight)
            {
                Console.WriteLine($"Yes, sum = {sumRight}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sumRight - sumLeft)}");
            }

        }
    }
}
