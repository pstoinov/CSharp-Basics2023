using System;

namespace _01USDToBGN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double usd = 1.79549;
            double bgn = double.Parse(Console.ReadLine());
            double converted = usd * bgn;
            Console.WriteLine(converted);
        }
    }
}
