using System;
using System.Diagnostics.CodeAnalysis;

namespace Demo
{
    class MyApplication
    {
        public static void Main()
        {
            int totalSoldTickets = 0, standardTickets = 0, studentTickets = 0, kidTickets = 0; 
            
            string movie = Console.ReadLine();
            while (movie != "Finish")
            {
                int freeSeats = int.Parse(Console.ReadLine());
                int soldTicketsForCurrentProjection = 0;

                string ticketType = Console.ReadLine();
                while (soldTicketsForCurrentProjection < freeSeats && ticketType != "End")
                {
                    if (ticketType == "standard")
                    {
                        standardTickets++;
                    }
                    else if (ticketType == "student")
                    {
                        studentTickets++;
                    }
                    else if (ticketType == "kid")
                    {
                        kidTickets++;
                    }

                    soldTicketsForCurrentProjection++;
                    if (soldTicketsForCurrentProjection < freeSeats)
                    {

                        ticketType = Console.ReadLine();
                    }
                    

                }
                double fillPercentage = (double)soldTicketsForCurrentProjection / freeSeats * 100;
                Console.WriteLine($"{movie} - {fillPercentage:f2}% full.");
                totalSoldTickets += soldTicketsForCurrentProjection;
                movie = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {totalSoldTickets}");
            Console.WriteLine($"{(double)studentTickets / totalSoldTickets * 100:f2}% student tickets.");
            Console.WriteLine($"{(double)standardTickets / totalSoldTickets * 100:f2}% standard tickets.");
            Console.WriteLine($"{(double)kidTickets / totalSoldTickets * 100:f2}% kids tickets.");
        }
    }
}