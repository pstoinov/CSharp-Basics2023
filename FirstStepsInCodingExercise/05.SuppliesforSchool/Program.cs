using System;

namespace _05.SuppliesforSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int packPens = int.Parse(Console.ReadLine());
            int packMarkers = int.Parse(Console.ReadLine());
            int litersCleaner = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());
            double pens = 5.80;
            double markers = 7.20;
            double cleaner = 1.20;
            double sum = (packPens * pens) + (packMarkers * markers) + (litersCleaner * cleaner);
            double sumDiscount = sum * (discount * 0.01);
            double total = sum - sumDiscount;
            Console.WriteLine(total);



        }
    }
}
