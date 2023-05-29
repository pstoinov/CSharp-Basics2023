using System;

namespace _07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chikenMenu = int.Parse(Console.ReadLine());
            int fishMenu = int.Parse(Console.ReadLine());
            int vegieMenu = int.Parse(Console.ReadLine());
            double delivery = 2.5;
            double sumChiken = chikenMenu * 10.35;
            double sumFish = fishMenu * 12.40;
            double sumVegie = vegieMenu * 8.15;
            double sumAll = sumChiken + sumFish + sumVegie;
            double desert = sumAll * 0.20;
            double totalCost = sumAll + desert + delivery;
            Console.WriteLine(totalCost);
        }
    }
}
