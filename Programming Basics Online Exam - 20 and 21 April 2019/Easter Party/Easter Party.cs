using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double priceForGuest = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());


            if (guests >= 10 && guests <= 15)
            {
                priceForGuest -= priceForGuest * 0.15;
            }
            else if (guests > 15 && guests <= 20)
            {
                priceForGuest -= priceForGuest * 0.20;
            }
            else if (guests > 20)
            {
                priceForGuest -= priceForGuest * 0.25;
            }

            double totalGuestPrice = priceForGuest * guests;
            double cakePrice = budget * 0.10;
            double total = totalGuestPrice + cakePrice;

            if (budget >= total)
            {
                Console.WriteLine($"It is party time! {budget - total:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"No party! {total - budget:f2} leva needed.");
            }
        }
    }
}
