using System;

namespace _08.LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            int movieDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());
            double timeForLunch = breakDuration * 0.125;
            double timeForRest = breakDuration * 0.25;
            double requiredTime = movieDuration + timeForLunch + timeForRest;
            if (requiredTime <= breakDuration)
            {
                Console.WriteLine($"You have enough time to watch {movieName} and left with {Math.Ceiling(breakDuration - requiredTime)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {movieName}, you need {Math.Ceiling(requiredTime - breakDuration)} more minutes.");
            }
        }
    }
}
