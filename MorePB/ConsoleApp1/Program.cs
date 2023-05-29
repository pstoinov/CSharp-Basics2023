using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double hInCm = h * 100;
            double wInCm = w * 100;
            double hWithoutCorridor = hInCm - 100;
            int workingPlaces = (int)hWithoutCorridor / 70;
            int rows = (int)wInCm / 120;
            int allWorkingPlaces = workingPlaces * rows - 3;
            Console.WriteLine(allWorkingPlaces);

        }
    }
}
