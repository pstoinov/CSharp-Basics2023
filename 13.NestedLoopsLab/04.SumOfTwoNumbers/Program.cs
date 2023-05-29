using System;

namespace _04.SumOfTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            int validCounter = 0;
            bool flag = false;

            for (int i = num1; i <= num2; i++)
            {
                for (int j = num1; j <= num2; j++)
                {
                    validCounter++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{validCounter} ({i} + {j} = {magicNum})");
                        flag = true;
                        break;
                    }
                }
                if (flag) { break; }
            }
            if (!flag) { Console.WriteLine($"{validCounter} combinations - neither equals {magicNum}"); }


        }
    }
}
