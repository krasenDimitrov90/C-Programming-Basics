using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Energy_Booster
{
    class Program
    {
        static void Main(string[] args)
        {
            //                   Диня              Манго           Ананас           Малина
            // 2 броя(small)  56 лв./ бр.      36.66 лв./ бр.   42.10 лв./ бр.   20 лв./ бр.
            // 5 броя(big)    28.70 лв./ бр.   19.60 лв./ бр.   24.80 лв./ бр.   15.20 лв./ бр.

            string fruit = Console.ReadLine();// Type of fruit 
            string package = Console.ReadLine();// "Small" or "Big"
            int countPackage = int.Parse(Console.ReadLine());// Count of packages

            //  от 400 лв.до 1000 лв.включително има 15 % отстъпка
            //  над 1000 лв.има 50 % отстъпка

            double totalPrice = 0;

            if (package == "small")
            {
                if (fruit == "Watermelon")
                {
                    totalPrice = 56.0 * countPackage * 2;
                }
                else if (fruit == "Mango")
                {
                    totalPrice = 36.66 * countPackage * 2;
                }
                else if (fruit == "Pineapple")
                {
                    totalPrice = 42.1 * countPackage * 2;
                }
                else if (fruit == "Raspberry")
                {
                    totalPrice = 20.0 * countPackage * 2;
                }
            }
            else if (package == "big")
            {
                if (fruit == "Watermelon")
                {
                    totalPrice = 28.7 * countPackage * 5;
                }
                else if (fruit == "Mango")
                {
                    totalPrice = 19.6 * countPackage * 5;
                }
                else if (fruit == "Pineapple")
                {
                    totalPrice = 24.8 * countPackage * 5;
                }
                else if (fruit == "Raspberry")
                {
                    totalPrice = 15.2 * countPackage * 5;
                }
            }
            if (totalPrice < 400)
            {
                totalPrice = totalPrice;
            }

            else if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.50;
            }

            Console.WriteLine($"{totalPrice:f2} lv.");
        }
    }
}
