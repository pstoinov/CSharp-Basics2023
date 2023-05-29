using System;
using System.Text;

namespace _09.weather
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string weather = Console.ReadLine();
            //if (weather == "sunny") Console.WriteLine("It's warm outside!");
            //else Console.WriteLine("It's cold outside!");
            string value = "Experience";
            // Convert the string into a byte[].
            byte[] asciiBytes = Encoding.ASCII.GetBytes(value);

            int total = 0;

            foreach (var i in asciiBytes)
            {
                total += i;
            }
            Console.WriteLine(total);
        }
    }
}
