using System;

namespace _05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine(); 
            double price = 0;
            string destination = "";
            string place = "";
            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.3;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.7;
                    place = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.4;
                    place = "Camp";
                }
                else if (season == "winter")
                {
                    price = budget * 0.8;
                    place = "Hotel";
                }
            }
            else if (budget > 1000)
            {               
                    place = "Hotel";
                
                destination = "Europe";
                price = budget * 0.9;
            }

            Console.WriteLine("Somewhere in " + destination);
            Console.WriteLine(place + " - " + $"{price:F2}");

        }
    }
}
