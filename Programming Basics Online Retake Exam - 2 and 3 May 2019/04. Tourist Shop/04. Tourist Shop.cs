using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());

            string productType = Console.ReadLine();
            double totalPriceForAll = 0;
            int productCounter = 0;
            while (productType != "Stop" || budget < totalPriceForAll)
            {
                
                double productPrice = double.Parse(Console.ReadLine());
                productCounter++;
                if (productCounter % 3 == 0)
                {
                    productPrice *= 0.50;
                }
                totalPriceForAll += productPrice;
                if (budget < totalPriceForAll)
                {
                    break;
                }
                productType = Console.ReadLine();

            }
            if (budget >= totalPriceForAll)
            {
                Console.WriteLine($"You bought {productCounter} products for {totalPriceForAll:f2} leva.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money!");
                Console.WriteLine($"You need {totalPriceForAll - budget:f2} leva!");
            }
        }
    }
}
