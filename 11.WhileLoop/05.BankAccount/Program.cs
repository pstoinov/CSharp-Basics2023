using System;

namespace _05.BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string deposit = string.Empty;
            double money = 0;

            while ((deposit = Console.ReadLine()) != "NoMoreMoney") 
            {
                double currentIncome = double.Parse(deposit);
                    if (currentIncome <0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                    money += currentIncome;
                Console.WriteLine($"Increase: {currentIncome:F2}");
            }
            Console.WriteLine($"Total: {money:F2}");
        }
    }
}
