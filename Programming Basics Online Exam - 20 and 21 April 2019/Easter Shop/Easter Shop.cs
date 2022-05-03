using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsInShop = int.Parse(Console.ReadLine());
            int leftEggs = eggsInShop;

            string statement = Console.ReadLine();
            int soldEgss = 0;

            bool zeroEggsLeft = false;

            while (statement != "Close" && leftEggs >= 0)
            {
                string eggsBuyFill = Console.ReadLine();

                if (statement == "Buy")
                {
                    int buy = int.Parse(eggsBuyFill);
                    if (leftEggs - buy < 0)
                    {
                        zeroEggsLeft = true;
                        break;
                    }
                    else
                    {
                        leftEggs -= buy;
                        soldEgss += buy;
                    }
                }
                else if (statement == "Fill")
                {
                    int Fill = int.Parse(eggsBuyFill);
                    leftEggs += Fill;
                }
                if (leftEggs < 0)
                {
                    break;
                }
                statement = Console.ReadLine();
            }
            if (zeroEggsLeft)
            {
                Console.WriteLine("Not enough eggs in store!");
                Console.WriteLine($"You can buy only {leftEggs}.");
            }
            else
            {
                Console.WriteLine("Store is closed!");
                Console.WriteLine($"{soldEgss} eggs sold.");
            }
        }
    }
}
