using System;

namespace _07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int stay = int.Parse(Console.ReadLine());
            double priceApart = 0;
            double priceStudio = 0;
            if (month == "May" || month == "October")
            {
                if (stay <= 7)
                {
                    priceStudio = stay * 50.0;
                    priceApart = stay * 65.0;
                }
                else if (stay > 7 && stay <= 14)
                {
                    priceStudio = (stay * 50.0) * 0.95;
                    priceApart = stay * 65.0;
                }
                else
                {
                    priceStudio = (stay * 50.0) * 0.7;
                    priceApart = (stay * 65.0) * 0.9;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (stay <= 14)
                {
                    priceStudio = stay * 75.20;
                    priceApart = stay * 68.70;
                }
                
                else
                {
                    priceStudio = (stay * 75.20) * 0.8;
                    priceApart = (stay * 68.70) * 0.9;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (stay <= 14)
                {
                    priceStudio = stay * 76.0;
                    priceApart = stay * 77.0;

                }
                else
                {
                    priceStudio = stay * 76.0;
                    priceApart = (stay * 77.0) * 0.9;
                }
            }
            Console.WriteLine($"Apartment: {priceApart:F2} lv.");
            Console.WriteLine($"Studio: {priceStudio:F2} lv.");

        }
    }
}
