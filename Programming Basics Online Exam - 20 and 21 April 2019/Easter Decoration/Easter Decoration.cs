using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Decoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());

            double averageBill = 0;

              //•	кошничка за яйца(basket) – 1.50 лв.
              //•	великденски венец(wreath) – 3.80 лв.
              //•	шоколадов заек(chocolate bunny) – 7 лв.


            for (int i = 0; i < clientsCount; i++)
            {
                string product = Console.ReadLine(); 
                int productCounter = 0;
                double totalPriceForClient = 0;

                while (product != "Finish")
                {
                    double priceForProduct = 0;
                    
                    productCounter++;

                    if (product == "basket")
                    {
                        priceForProduct = 1.50;
                    }
                    else if (product == "wreath")
                    {
                        priceForProduct = 3.80;
                    }
                    else if (product == "chocolate bunny")
                    {
                        priceForProduct = 7.00;
                    }
                    totalPriceForClient += priceForProduct;
                    

                    product = Console.ReadLine();
                }
                if (productCounter % 2 == 0)
                {
                    totalPriceForClient -= totalPriceForClient * 0.20;
                }
                averageBill += totalPriceForClient;

                Console.WriteLine($"You purchased {productCounter} items for {totalPriceForClient:f2} leva.");
            }

            Console.WriteLine($"Average bill per client is: {averageBill / clientsCount:f2} leva.");
        }
    }
}
