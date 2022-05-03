using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Travel_Agency
{
    class Program
    {
        static void Main(string[] args)
        {
            string cityName = Console.ReadLine();
            string packegeType = Console.ReadLine();
            string statusVIP = Console.ReadLine();
            int daysOfStay = int.Parse(Console.ReadLine());
            if (daysOfStay < 1)
            {
                Console.WriteLine("Days must be positive number!");
                return;
            }

            double priceForADay = 0;
            double vipDiscount = 0;
            double totalPrice = 0;

            switch (cityName)
            {
                default:
                    Console.WriteLine("Invalid input!");
                    return;
                case "Bansko":
                case "Borovets":
                    switch (packegeType)
                    {
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                        case "noEquipment":
                            priceForADay = 80;
                            vipDiscount = 0.05;
                            break;
                        case "withEquipment":
                            priceForADay = 100;
                            vipDiscount = 0.10;
                            break;
                    }
                    break;
                case "Varna": 
                case "Burgas":
                    switch (packegeType)
                    {
                        default:
                            Console.WriteLine("Invalid input!");
                            return;
                        case "noBreakfast":
                            priceForADay = 100;
                            vipDiscount = 0.07;
                            break;
                        case "withBreakfast":
                            priceForADay = 130;
                            vipDiscount = 0.12;
                            break;
                    }
                    break;
            }

            if (daysOfStay > 7)
            {
                daysOfStay -= 1;
            }
            if (statusVIP == "yes")
            {
                priceForADay -= priceForADay * vipDiscount;
                totalPrice = (daysOfStay * priceForADay);
                
            }
            else if (statusVIP == "no")
            {
                totalPrice = (daysOfStay * priceForADay);
            }

            Console.WriteLine($"The price is {totalPrice:f2}lv! Have a nice time!");
        }
    }
}
