using System;

namespace _07.SumNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int num;
            for (int i = 1; i <= n; i++)
            {
                num = int.Parse(Console.ReadLine());
                sum += num;
                
            }
            Console.WriteLine(sum);
        }
    }
}
