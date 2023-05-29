using System;

namespace _01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int colum = int.Parse(Console.ReadLine());
            double price = 0;
            switch (type)
            {
                case "Premiere":
                    price = 12.0;
                    break;
                case "Normal":
                    price = 7.50;
                    break;
                case "Discount":
                    price = 5.0;
                    break;
            }
            Console.WriteLine($"{row * colum * price:f2} leva");
        }
    }
}
