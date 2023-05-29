using System;

namespace _01.PipeInPools
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int volumePool = int.Parse(Console.ReadLine());
            int pipe1Debit = int.Parse(Console.ReadLine());
            int pipe2Debit = int.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double pipe1Fill = pipe1Debit * hours;
            double pipe2Fill = pipe2Debit * hours;
            double sumFill = pipe1Fill + pipe2Fill;
            if (sumFill <= volumePool)
            {
                Console.WriteLine($"The pool is {sumFill / volumePool * 100:F2}% full. Pipe 1: {pipe1Fill / sumFill * 100:F2}%. Pipe 2: {pipe2Fill / sumFill * 100:F2}%.");
            }
            else
            {
                Console.WriteLine($"For {hours:f2} hours the pool overflows with {sumFill - volumePool:f2} liters.");
            }
        }
    }
}
