using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SquareArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int area = a * b;
            Console.WriteLine(area);
        }
    }
}
