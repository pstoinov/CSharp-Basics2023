using System;

namespace _04.VegetableMarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double vegiePrice = double.Parse(Console.ReadLine());
            double fruitPrice = double.Parse(Console.ReadLine());
            int vegieKg = int.Parse(Console.ReadLine());
            int fruiteKg = int.Parse(Console.ReadLine());
            double totalPrice = ((vegiePrice * vegieKg) + (fruitPrice * fruiteKg)) / 1.94;
            Console.WriteLine($"{totalPrice:f2}");

        }
    }
}
