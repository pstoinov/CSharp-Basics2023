using System;

namespace Cinema_Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // vars
            // vars Console
            string nameOrFinish = "";
            double sits = 0.0;
            string ticketOrEnd = "";
            // vars FInish
            double ticketsAll = 0.0;
            double ticketsFilm = 0.0;
            double ticketsStu = 0.0;
            double ticketsKid = 0.0;
            double ticketsSta = 0.0;
            // vars End
            string filmName = "";
            double freeSits = 0.0;
            // vars Teck
            bool isEnd = false;

            nameOrFinish = Console.ReadLine();
            while (nameOrFinish != "Finish")
            {
                sits = double.Parse(Console.ReadLine());
                for (int i = 1; i <= sits || sits == 0; i++)
                {
                    if (isEnd)
                    {
                        isEnd = false;
                        break;
                    }
                    ticketOrEnd = Console.ReadLine();
                    switch (ticketOrEnd)
                    {
                        case "student":
                            ticketsFilm++;
                            ticketsStu++;
                            break;
                        case "standard":
                            ticketsFilm++;
                            ticketsSta++;
                            break;
                        case "kid":
                            ticketsFilm++;
                            ticketsKid++;
                            break;
                        case "End":
                            isEnd = true;
                            Console.WriteLine($"{nameOrFinish} - {(100.0 * ticketsFilm / sits):f2}% full.");
                            break;
                        default:
                            Console.WriteLine("Input problem!");
                            return;
                    }
                    if (sits == ticketsFilm || sits == 0)
                    {
                        Console.WriteLine($"{nameOrFinish} - {(100.0 * ticketsFilm / sits):f2}% full.");
                        ticketsFilm = 0;
                        break;
                    }


                }
                ticketsAll += ticketsFilm;
                ticketsFilm = 0;
                nameOrFinish = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {Math.Floor(ticketsAll)}");
            Console.WriteLine($"{(100 * ticketsStu / ticketsAll):f2}% student tickets.");
            Console.WriteLine($"{(100 * ticketsSta / ticketsAll):f2}% standard tickets.");
            Console.WriteLine($"{(100 * ticketsKid / ticketsAll):f2}% kids tickets.");
        }
    }
}