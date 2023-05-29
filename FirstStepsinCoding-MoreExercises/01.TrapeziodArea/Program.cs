using System;

namespace _01.TrapeziodArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());  
            double h = double.Parse(Console.ReadLine());
            double s = (a + b) * h / 2;
            Console.WriteLine($"{s:f2}");
        }
    }
}
