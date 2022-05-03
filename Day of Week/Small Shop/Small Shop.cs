using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string item = Console.ReadLine();
            string city = (Console.ReadLine());
            double quantity = double.Parse(Console.ReadLine());
            //       coffee   water   beer   sweets  peanuts
            //Sofia   0.50    0.80    1.20    1.45    1.60
            //Plovdiv 0.40    0.70    1.15    1.30    1.50
            //Varna   0.45    0.70    1.10    1.35    1.55
            double priceItem = 0;

            switch (city)
            {
                case "Sofia":
                    if (item == "coffee")
                    {
                        priceItem = 0.50;
                    }
                    else if (item == "water")
                    {
                        priceItem = 0.80;
                    }
                    else if (item == "beer")
                    {
                        priceItem = 1.2;
                    }
                    else if (item == "sweets")
                    {
                        priceItem = 1.45;
                    }
                    else if (item == "peanuts")
                    {
                        priceItem = 1.60;
                    }
                    break;
                case "Plovdiv":
                    if (item == "coffee")
                    {
                        priceItem = 0.40;
                    }
                    else if (item == "water")
                    {
                        priceItem = 0.70;
                    }
                    else if (item == "beer")
                    {
                        priceItem = 1.15;
                    }
                    else if (item == "sweets")
                    {
                        priceItem = 1.30;
                    }
                    else if (item == "peanuts")
                    {
                        priceItem = 1.50;
                    }
                    break;

                case "Varna":
                    if (item == "coffee")
                    {
                        priceItem = 0.45;
                    }
                    else if (item == "water")
                    {
                        priceItem = 0.70;
                    }
                    else if (item == "beer")
                    {
                        priceItem = 1.10;
                    }
                    else if (item == "sweets")
                    {
                        priceItem = 1.35;
                    }
                    else if (item == "peanuts")
                    {
                        priceItem = 1.55;
                    }
                    break;
            }

            double totalPrice = priceItem * quantity;
            Console.WriteLine(totalPrice);
        }
    }
}
