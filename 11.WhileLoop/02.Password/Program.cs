﻿using System;

namespace _02.Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = Console.ReadLine();
            string pass = Console.ReadLine();
            string input = Console.ReadLine();
            while (input != pass)
            {
                input = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {user}!");
        }
    }
}
