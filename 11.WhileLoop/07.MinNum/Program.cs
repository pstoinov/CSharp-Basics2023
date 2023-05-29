using System;

namespace _07.MinNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numbers = Console.ReadLine();
            int maxNum = int.MaxValue;

            while (numbers != "Stop")
            {
                int currNum = int.Parse(numbers);
                if (currNum < maxNum)
                {
                    maxNum = currNum;
                }
                numbers = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
