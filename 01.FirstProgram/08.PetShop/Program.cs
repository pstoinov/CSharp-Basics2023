using System;

namespace _08.PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());
            double dog = dogFood * 2.50;
            double cat = catFood * 4.0;
            double finalPrice = dog + cat;
            Console.WriteLine($"{finalPrice} lv.");
        }
    }
}
