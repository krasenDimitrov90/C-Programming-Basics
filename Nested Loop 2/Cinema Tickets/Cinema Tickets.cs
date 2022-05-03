using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();
            
            double allTickets = 0;

            int student = 0;
            int standard = 0;
            int kid = 0;

            while (movie != "Finish")
            {
                string ticketType = "";
                double freeSeats = double.Parse(Console.ReadLine());
                int seats = 0;
                while (seats < freeSeats && ticketType != "End")
                {
                    
                    ticketType = Console.ReadLine();
                    if (ticketType == "student")
                    {
                        
                        seats++;
                        student++;
                    }
                    else if (ticketType == "standard")
                    {
                        
                        seats++;
                        standard++;
                    }
                    else if (ticketType == "kid")
                    {
                        
                        seats++;
                        kid++;
                    }
                    
                }
                allTickets += seats;
                Console.WriteLine($"{movie} - {seats / freeSeats * 100:f2}% full.");

                movie = Console.ReadLine();

            }

            Console.WriteLine($"Total tickets: {allTickets}");
            Console.WriteLine($"{student / allTickets * 100.0:f2}% student tickets.");
            Console.WriteLine($"{standard / allTickets * 100.0:f2}% standard tickets.");
            Console.WriteLine($"{kid / allTickets * 100.0:f2}% kids tickets.");
        }
    }
}
