using System;

namespace _06.WorldSwimmingRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInM = double.Parse(Console.ReadLine());
            double timeInSeconds = double.Parse(Console.ReadLine());
            double mustSwim = timeInSeconds * distanceInM;
            double waterResist = Math.Floor(distanceInM / 15) * 12.5;
            double totalTime = mustSwim + waterResist;
            if (totalTime < recordInSeconds)
            {
                Console.WriteLine($" Yes, he succeeded! The new world record is {totalTime:F2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {Math.Abs(totalTime - recordInSeconds):F2} seconds slower.");
            }
        }
    }
}
