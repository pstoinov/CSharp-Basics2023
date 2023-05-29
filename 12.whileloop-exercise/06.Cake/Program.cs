using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeLenght = int.Parse(Console.ReadLine());
            int cakeWidth = int.Parse(Console.ReadLine());
            int cake = cakeLenght * cakeWidth;

            while (cake > 0)
            {
                string cakePeices = Console.ReadLine();
                if (cakePeices == "STOP")
                {
                    break;
                }
                else
                {
                    int takenPeices = int.Parse(cakePeices);
                    cake -= takenPeices;
                }
            }
            if (cake >= 0)
            {
                Console.WriteLine($"{cake} pieces are left.");
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
