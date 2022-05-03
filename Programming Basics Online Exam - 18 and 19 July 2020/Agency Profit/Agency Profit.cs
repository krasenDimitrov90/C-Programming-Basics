using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agency_Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            string airCompany = Console.ReadLine();// name of the company
            int oldTickets = int.Parse(Console.ReadLine());// count
            int kidTiteckts = int.Parse(Console.ReadLine());// count
            double netOldPrice = double.Parse(Console.ReadLine());// price of old ticket
            double servicePrice = double.Parse(Console.ReadLine());// Service tax for the Agency

            double netKidPrice = 0.30 * netOldPrice;// price of kid ticket
            netKidPrice = netKidPrice * kidTiteckts;
            netOldPrice = netOldPrice * oldTickets;
            servicePrice = servicePrice * (oldTickets + kidTiteckts);

            double totalPrice = netKidPrice + netOldPrice + servicePrice;

            Console.WriteLine($"The profit of your agency from {airCompany} tickets is {totalPrice * 0.20:f2} lv.");

        }
    }
}
