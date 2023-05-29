using System;

namespace _09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double fill = double.Parse(Console.ReadLine());
            double volumeInCm = length * width * height;
            double volumeInLit = volumeInCm * 0.001;
            double fillKoef = fill * 0.01;
            double litReq = volumeInLit * (1 - fillKoef);
            Console.WriteLine(litReq);
        }
    }
}
