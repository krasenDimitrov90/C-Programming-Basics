using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            double excursionMoney = double.Parse(Console.ReadLine()); // Money need for the excursion
            double availableMoney = double.Parse(Console.ReadLine()); // Start money

            int spendCounter = 0;
            int dayCounter = 0;

            while (spendCounter < 5)
            {
                string action = Console.ReadLine(); // Action - "Spend" or "Save"
                double spendSavedMoney = double.Parse(Console.ReadLine()); // Spend or Saved money
                dayCounter++;
                if (action == "spend")
                {
                    spendCounter++;
                    availableMoney -= spendSavedMoney;
                }
                else if (action == "save")
                {
                    spendCounter *= 0;
                    availableMoney += spendSavedMoney;
                }
                
                if (availableMoney >= excursionMoney)
                {
                    Console.WriteLine($"You saved the money for {dayCounter} days.");
                    break;
                }
                if (availableMoney < 0)
                {
                    availableMoney = 0;
                }
                if (spendCounter == 5)
                {
                    Console.WriteLine($"You can't save the money.");
                    Console.WriteLine($"{dayCounter}");
                }
            }
            
        }
    }
}
