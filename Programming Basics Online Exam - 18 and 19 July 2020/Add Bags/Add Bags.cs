using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            double luggagePrice = double.Parse(Console.ReadLine());// Price of luggage abouth 20 kg
            double luggageSize = double.Parse(Console.ReadLine());// Kg of the luggage
            int daysToFly = int.Parse(Console.ReadLine());// Left days to fly
            int luggageCount = int.Parse(Console.ReadLine());// How many luggages are

            if (luggageSize < 10)
            {
                luggagePrice = luggagePrice * 0.20;
            }
            else if (luggageSize >= 10 && luggageSize <= 20)
            {
                luggagePrice = luggagePrice * 0.50;
            }
            else
            {
                luggagePrice = luggagePrice;
            }

            if (daysToFly > 30)
            {
                luggagePrice = luggagePrice + luggagePrice * 0.10;
            }
            else if (daysToFly <= 30 && daysToFly >= 7)
            {
                luggagePrice = luggagePrice + luggagePrice * 0.15;
            }
            else if (daysToFly < 7)
            {
                luggagePrice = luggagePrice + luggagePrice * 0.40;
            }

            luggagePrice = luggagePrice * luggageCount;

            Console.WriteLine($" The total price of bags is: {luggagePrice:f2} lv. ");
        }
    }
}
