using System;

namespace _06.Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int naylon = int.Parse(Console.ReadLine());
            int paint = int.Parse(Console.ReadLine());
            int thinner = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double priceNaylon = 1.5;
            double pricePaint = 14.5;
            double priceThinner = 5.0;
            double priceBag = 0.40;
            double allNaylon = (naylon + 2) * priceNaylon;
            double allPaint = (paint * 1.1) * pricePaint;
            double allThinner = thinner * priceThinner;
            double allMat = allNaylon + allPaint + allThinner + priceBag;
            double wagePerHour = allMat * 0.30;
            double totalCost = allMat + (wagePerHour * hours);
            Console.WriteLine($"{totalCost}");

        }
    }
}
