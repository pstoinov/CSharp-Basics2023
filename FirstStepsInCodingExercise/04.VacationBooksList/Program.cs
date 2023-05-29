using System;

namespace _04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pagesOfBook = int.Parse(Console.ReadLine());
            int pagesPerHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int HoursPerDay = ((pagesOfBook / pagesPerHour) / days);
            Console.WriteLine(HoursPerDay);

        }
    }
}
