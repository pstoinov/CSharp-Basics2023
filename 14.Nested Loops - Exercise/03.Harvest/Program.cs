using System;

namespace _03.Harvest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area = int.Parse(Console.ReadLine());
            double grapePerSqrMeter = double.Parse(Console.ReadLine());
            int neededWine = int.Parse(Console.ReadLine());
            int countWorkers = int.Parse(Console.ReadLine());
            double harvestedGrape = (double)area * grapePerSqrMeter;
            double wine = (harvestedGrape * 0.4) / 2.5;

            if (neededWine > wine)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(neededWine - wine)} liters wine needed.");
            }
            else
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(wine)} liters.");
                Console.WriteLine($"{Math.Ceiling(wine - neededWine)} liters left -> {Math.Ceiling((wine - neededWine)/countWorkers)} liters per person.");
            }


        }
    }
}
