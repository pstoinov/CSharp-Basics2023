using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeededForVacation = double.Parse(Console.ReadLine());
            double ownedMoney = double.Parse(Console.ReadLine());
            bool isValid = true;
            int countSpend = 0;
            int countDays = 0;
            while (isValid)
            {

                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());
                countDays++;
                if (action == "save")
                {
                    ownedMoney += money;
                    countSpend = 0;

                    if (ownedMoney >= moneyNeededForVacation)
                    {
                        break;
                    }
                }
                else if (action == "spend")
                {
                    ownedMoney -= money;
                    countSpend++;

                    if (countSpend > 4)
                    {
                        break;
                    }
                    if (ownedMoney < 0)
                    {
                        ownedMoney = 0;
                    }

                }
                ownedMoney = Math.Round(ownedMoney, 2);
                if (ownedMoney >= moneyNeededForVacation)
                    isValid = false;
            }
            if (ownedMoney >= moneyNeededForVacation)
                Console.WriteLine($"You saved the money for {countDays} days.");
            else
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(countDays);
            }
        }
    }
}
