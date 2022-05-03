using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Safari
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double fuelLiters = double.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            double fuelPrice = 2.10 * fuelLiters;
            double gidPrice = 100;
            double discount = 0;
            if (dayOfWeek == "Saturday")
            {
                discount = 0.90;// it means 10 procent discount
            }
            else if (dayOfWeek == "Sunday")
            {
                discount = 0.80;// it means 20 procent discount
            }
            double wholePrice = (fuelPrice + gidPrice) * discount;
            if (budget >= wholePrice)
            {
                Console.WriteLine($"Safari time! Money left: {budget - wholePrice:f2} lv. ");
            }
            else
            {
                Console.WriteLine($"Not enough money! Money needed: {wholePrice - budget:f2} lv.");
            }
        }
    }
}
