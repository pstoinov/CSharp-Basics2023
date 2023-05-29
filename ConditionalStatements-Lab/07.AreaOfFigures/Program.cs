using System;
using System.Dynamic;

namespace _07.AreaOfFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            if (figure == "square") 
            {
                double a = double.Parse(Console.ReadLine());
                double areaOfSquare = a * a;
                Console.WriteLine($"{areaOfSquare:f3}");
            }
            else 
            {
                if (figure == "rectangle")
                {
                    double rectangleSideA = double.Parse(Console.ReadLine());
                    double rectangleSideB = double.Parse(Console.ReadLine());
                    double areaOfRect = rectangleSideA * rectangleSideB;
                    Console.WriteLine($"{areaOfRect:f3}");
                }
                else 
                {
                    if (figure == "circle") 
                    {
                        double r = double.Parse(Console.ReadLine());
                        double areaOfCircle = Math.PI * Math.Pow(r,2);
                        Console.WriteLine($"{areaOfCircle:f3}");
                    }
                    else 
                    {
                        if (figure == "triangle")
                        {
                            double sideOfTriangle = double.Parse(Console.ReadLine());
                            double hOfTriangle = double.Parse(Console.ReadLine());
                            double areaOfTriangle = 0.5 * sideOfTriangle * hOfTriangle;
                            Console.WriteLine($"{areaOfTriangle:f3}");
                        }
                    }
                }
            }
        }
    }
}
