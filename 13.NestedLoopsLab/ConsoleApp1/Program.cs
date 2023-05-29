using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int finish = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int count = 0;

            bool isFound = false;
            for (int i = start; i <= finish; i++)
            {
                for (int n = 0; n <= finish; n++)
                {
                    count++;
                    if (i + n == magicNum)
                    {
                        Console.WriteLine($"Combination N:{count} ({i} + {n} = {magicNum})");
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{count} combinations - neither equals {magicNum}");
            }
        }
    }
}
