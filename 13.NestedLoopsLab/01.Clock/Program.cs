using System;

namespace _01.Clock
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 23; i++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine($"{i}:{m}");
                }
            }
        }
    }
}
