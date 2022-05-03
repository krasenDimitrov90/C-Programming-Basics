using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Report_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int charitySum = int.Parse(Console.ReadLine());
            int PayCounter = 0;
            double cashPaySum = 0;
            double cardPaySum = 0;
            int cashCounter = 0;
            int cardCounter = 0;
            int totalSumOFArticuls = 0;

            string priceOfArticul = Console.ReadLine();

            while (priceOfArticul != "End" && totalSumOFArticuls <= charitySum)
            {
                int price = int.Parse(priceOfArticul);
                
                PayCounter++;
                if (PayCounter % 2 != 0)
                {
                    if (price > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {
                        totalSumOFArticuls += price;
                        cashPaySum += price;
                        cashCounter++;
                        Console.WriteLine("Product sold!");
                    }
                }
                else 
                {
                    if (price < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                        
                    }
                    else
                    {
                        totalSumOFArticuls += price;
                        cardPaySum += price;
                        cardCounter++;
                        Console.WriteLine("Product sold!");
                    }
                }
                if (totalSumOFArticuls >= charitySum)
                {
                    Console.WriteLine($"Average CS: {(cashPaySum / cashCounter):f2}");
                    Console.WriteLine($"Average CC: {(cardPaySum / cardCounter):f2}");
                    return;
                }
                priceOfArticul = Console.ReadLine();

            }
            Console.WriteLine("Failed to collect required money for charity.");
            
           
        }
    }
}
