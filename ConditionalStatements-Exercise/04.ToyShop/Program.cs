using System;

namespace _04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceTrip = double.Parse(Console.ReadLine());
            int puzzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int teddy = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trukcs = int.Parse(Console.ReadLine());
            double price = puzzels * 2.6 + dolls * 3 + teddy * 4.10 + minions * 8.20 + trukcs * 2;
            if (puzzels + dolls + teddy + minions + trukcs >= 50) 
            {
                price = price * 0.75;
            }
            double priceAfterTax = price * 0.9;
            if (priceAfterTax >= priceTrip) 
            {
                Console.WriteLine($"Yes! {priceAfterTax - priceTrip:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {priceTrip - priceAfterTax:F2} lv needed.");
            }
        }
    }
}
