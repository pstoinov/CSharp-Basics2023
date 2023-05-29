using System;

namespace _03.CelsiusToFahrenheit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cTemp = double.Parse(Console.ReadLine());
            double fTemp = cTemp * 1.8 + 32;
            Console.WriteLine($"{fTemp:f2}");
        }
    }
}
