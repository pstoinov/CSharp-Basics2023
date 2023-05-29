using System;

namespace _09.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string review = Console.ReadLine();
            int nights = days - 1;
            double price = 0;
            switch (type)
            {
                case "room for one person":
                    price = nights * 18.00;
                    break;
                case "apartment":
                    if (days < 10)
                    {
                        price = nights * 25.0 * 0.7;
                    }
                    else if (days <= 15)
                    {
                        price = nights * 25 * 0.65;
                    }
                    else
                    {
                        price = nights * 25 * 0.5;
                    }
                    break;
                case "president apartment":
                    if (days < 10) { price = nights * 35 * 0.9; }
                    else if (days <= 15) { price = nights * 35 * 0.85; }
                    else { price = nights * 35 * 0.80; }
                    break;
            }
            if (review == "positive")
            {
                price = price * 1.25;
            }
            else price = price * 0.9;
            Console.WriteLine($"{price:F2}");

        }
    }
}
