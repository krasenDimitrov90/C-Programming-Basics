using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_Boat
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read 3 variables from the console
            int budgetGroup = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberOfFisherman = int.Parse(Console.ReadLine());

            // Define what is the season : "Spring", "Summer", "Autumn", "Winter"
            //    Define how many fisherman there are

            double price = 0;

            


            if (season == "Spring")
            {
                if (numberOfFisherman <= 6)
                {
                    price = 3000 - 3000 * 0.10;
                }
                else if (numberOfFisherman <= 11)
                {
                    price = 3000 - 3000 * 0.15;
                }
                else
                {
                    price = 3000 - 3000 * 0.25;
                }
            }

            else if (season == "Summer" || season == "Autumn")
            {
                if (numberOfFisherman <= 6)
                {
                    price = 4200 - 4200 * 0.10;
                }
                else if (numberOfFisherman <= 11)
                {
                    price = 4200 - 4200 * 0.15;
                }
                else
                {
                    price = 4200 - 4200 * 0.25;
                }
            }
            
            
            else if (season == "Winter")
            {
                if (numberOfFisherman <= 6)
                {
                    price = 2600 - 2600 * 0.10;
                }
                else if (numberOfFisherman <= 11)
                {
                    price = 2600 - 2600 * 0.15;
                }
                else
                {
                    price = 2600 - 2600 * 0.25;
                }
            }

            if (season != "Autumn" && numberOfFisherman % 2 == 0)
            {
                price = price - price * 0.05;
            }

            if (budgetGroup >= price)
            {
                Console.WriteLine($"Yes! You have {budgetGroup - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budgetGroup:f2} leva.");
            }
        }
    }
}
