using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.World_Snooker_Championship
{
    class Program
    {
        static void Main(string[] args)
        {
            string championshipStage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketCount = int.Parse(Console.ReadLine());
            char picture = char.Parse(Console.ReadLine());// "Yes" or "No"

            double ticketPrice = 0;
            switch (championshipStage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 55.50;
                            break;
                        case "Premium":
                            ticketPrice = 105.20;
                            break;
                        case "VIP":
                            ticketPrice = 118.90;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 75.88;
                            break;
                        case "Premium":
                            ticketPrice = 125.22;
                            break;
                        case "VIP":
                            ticketPrice = 300.40;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 110.10;
                            break;
                        case "Premium":
                            ticketPrice = 160.66;
                            break;
                        case "VIP":
                            ticketPrice = 400;
                            break;
                    }
                    break;
            }

            int priceForPicture = 0;
            switch (picture)
            {
                case 'Y':
                    priceForPicture = 40;
                    break;
                case 'N':
                    priceForPicture = 0;
                    break;
            }

            double priceForAllTickets = ticketCount * ticketPrice;

            if (priceForAllTickets > 4000)
            {
                priceForAllTickets -= priceForAllTickets * 0.25;
                priceForPicture = 0;
            }
            else if (priceForAllTickets > 2500)
            {
                priceForAllTickets -= priceForAllTickets * 0.10;
            }
            

            double totalPrice = priceForAllTickets + ticketCount * priceForPicture;

            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
