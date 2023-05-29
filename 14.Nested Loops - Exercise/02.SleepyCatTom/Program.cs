using System;

namespace _02.SleepyCatTom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int cat = 30000;
            int holidaysPerYear = int.Parse(Console.ReadLine());
            int workingDays = 365 - holidaysPerYear;
            int playInHolidays = holidaysPerYear * 127;
            int playInWorkingDays = workingDays * 63;
            int totalPlay = playInWorkingDays + playInHolidays;
            int abs = Math.Abs(totalPlay - cat);
            

            if (totalPlay <= cat)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{abs / 60} hours and {abs % 60} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{abs / 60} hours and {abs % 60} minutes more for play");
            }

        }
    }
}
