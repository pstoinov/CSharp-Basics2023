using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int roomLenght = int.Parse(Console.ReadLine());
            int roomWidth = int.Parse(Console.ReadLine());
            int roomHeight = int.Parse(Console.ReadLine());
            int room = roomLenght * roomWidth * roomHeight;

            while (room > 0)
            {
                string packs = Console.ReadLine();
                if (packs == "Done")
                {
                    break;
                }
                else
                {
                    int packsNum = int.Parse(packs);
                    room -= packsNum;
                }
            }
            if (room >= 0)
            {
                Console.WriteLine($"{room} Cubic meters left.");
            }
            else
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(room)} Cubic meters more.");
            }
        }
    }
}
