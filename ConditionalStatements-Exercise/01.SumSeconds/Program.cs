﻿using System;

namespace _01.SumSeconds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int totalTime = first + second + third;
            int minutes = totalTime/ 60;
            int seconds = totalTime % 60;
            if (seconds < 10) { Console.WriteLine($"{minutes}:0{seconds}"); }
            else { Console.WriteLine($"{minutes}:{seconds}"); } 
        }
    }
}
