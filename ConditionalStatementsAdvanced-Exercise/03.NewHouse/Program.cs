using System;

namespace _03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double price = 0;
            switch (flowers)
            {
                case "Roses":
                    price = 5 * quantity;
                    
                    if (quantity > 80)
                    {
                        price = price * 0.9; 
                    }
                    break;
                case "Dahlias":
                    
                        price = quantity *3.8;
                    
                    if (quantity > 90) 
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Tulips":
                    
                        price = 2.8* quantity;
                    
                    if (quantity > 80)
                    {
                        price = price * 0.85;
                    }
                    break;
                case "Narcissus":
                    
                        price = 3.0 * quantity;
                    
                    if (quantity < 120)
                    {
                        price = price * 1.15;
                    }
                    break;
                case "Gladiolus":
                    
                    
                        price = 2.50 * quantity;
                    
                    if (quantity <80)
                    {
                        price = price * 1.2;
                    }
                    break;
            }
            
            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantity} {flowers} and {budget - price:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:F2} leva more.");
            }
        }
    }
}
