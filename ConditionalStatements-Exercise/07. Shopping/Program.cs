using System;

namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int gpu = int.Parse(Console.ReadLine());
            int cpu = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());
            double priceGpu = gpu * 250;
            double priceCpu = cpu * (priceGpu * 0.35);
            double priceRam = ram * (priceGpu * 0.1);
            double totalPrice = priceGpu + priceCpu + priceRam;
            if (gpu > cpu)
            {
                totalPrice = totalPrice * 0.85;
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}
