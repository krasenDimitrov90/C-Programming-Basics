using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ski_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfStay = int.Parse(Console.ReadLine());
            string typeOfRoom = Console.ReadLine();
            string rating = Console.ReadLine();

            int nightOfStay = dayOfStay - 1;
            double price = 0;

            if (typeOfRoom == "room for one person")
            {
                price = 18 * nightOfStay;
            }
            else if (typeOfRoom == "apartment")
            {
                price = 25 * nightOfStay;
                if (nightOfStay < 10)
                {
                    price = price - price * 0.30;
                }
                else if (nightOfStay < 15)
                {
                    price = price - price * 0.35;
                }
                else
                {
                    price = price - price * 0.50;
                }
            }
            else if (typeOfRoom == "president apartment")
            {
                price = 35 * nightOfStay;
                if (nightOfStay < 10)
                {
                    price = price - price * 0.10;
                }
                else if (nightOfStay < 15)
                {
                    price = price - price * 0.15;
                }
                else
                {
                    price = price - price * 0.20;
                }
            }

            if (rating == "positive")
            {
                price = price + price * 0.25;
            }
            else
            {
                price = price - price * 0.10;
            }
            Console.WriteLine($"{price:f2}");

        }
    }
}
