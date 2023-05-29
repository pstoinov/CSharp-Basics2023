using System;

namespace _03.Animal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();
            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;
                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;
                case "Mukcho":
                    Console.WriteLine("Pilinci");
                    break;
                default:
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
