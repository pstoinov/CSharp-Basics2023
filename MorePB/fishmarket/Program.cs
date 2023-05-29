using System;

namespace fishmarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double skumriaPrice = double.Parse(Console.ReadLine());
            double cacaPrice = double.Parse(Console.ReadLine());
            double palamudInKg = double.Parse(Console.ReadLine());
            double safridInKg = double.Parse(Console.ReadLine());
            double midiInKg = double.Parse(Console.ReadLine());
            double palamudPrice = skumriaPrice * 1.6;
            double safridPrice = cacaPrice * 1.8;
            double midiPrice = 7.5;
            double palamud = palamudInKg * palamudPrice;
            double safrid = safridInKg * safridPrice;
            double midi = midiInKg * midiPrice;
            double totalPrice = palamud + safrid + midi;
            //Console.WriteLine(Math.Round(totalPrice, 2));
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
