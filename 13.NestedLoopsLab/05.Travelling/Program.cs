﻿using System;

namespace _05.Travelling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
           

            while (destination != "End") 
            {
                double budget = double.Parse(Console.ReadLine());

                while (budget > 0) 
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    budget -= currentMoney;
                }
                Console.WriteLine($"Going to {destination}!");

                destination = Console.ReadLine();
            }
        }
    }
}
