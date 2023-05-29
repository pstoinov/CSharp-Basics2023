using System;

namespace _02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            double points = 0;
            if (digit <= 100) { points = 5; }
            else if (digit > 1000) { points = digit * 0.1; }
            else { points = digit * 0.2; }
            if (digit % 2 == 0)
            {
                points = points + 1;
            }
            else if (digit % 10 == 5) 
            {
                points = points + 2;
                
            }
            Console.WriteLine(points);
            Console.WriteLine(points + digit);


        }
    }
}
