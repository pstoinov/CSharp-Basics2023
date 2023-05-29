using System;

namespace _03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double dep = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double procents = double.Parse(Console.ReadLine());
            double calculated = dep + months * ((dep * procents / 100) / 12);
            Console.WriteLine(calculated);
        }
    }
}
