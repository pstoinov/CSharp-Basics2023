using System;

namespace _08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tax = int.Parse(Console.ReadLine());
            double shoes = tax * (1 - 0.4);
            double ekip = shoes * (1 - 0.2);
            double balls = ekip * 0.25;
            double acc = balls * 0.20;
            double totalCost = tax + shoes+ ekip +balls +acc;
            Console.WriteLine(totalCost);

        }
    }
}
