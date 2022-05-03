using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Mobile_operator
{
    class Program
    {
        static void Main(string[] args)
        {
            string contractPeriod = Console.ReadLine();
            string contractType = Console.ReadLine();
            string internet = Console.ReadLine();
            int countMothsForPay = int.Parse(Console.ReadLine());

            //  срок /    тип  Small       Middle       Large     ExtraLarge
            // 1 година(one)   9.98 лв.    18.99 лв.   25.98 лв.   35.99 лв.
            // 2 години(two)   8.58 лв.    17.09 лв.   23.59 лв.   31.79 лв.

            // o при такса по-малка или равна на 10.00 лв.  5.50 лв.
            // o при такса по-малка или равна на 30.00 лв.  4.35 лв.
            // o при такса по-голяма от 30.00 лв.  3.85 лв.
            // •	ако договорът e за две години, общата сума се намалява с 3.75 %

            double oneMonthCost = 0;
            double internetCostForMoth = 0;
            if (contractPeriod == "one")
            {
                switch (contractType)
                {
                    case  "Small":
                        oneMonthCost = 9.98;
                        break;
                    case "Middle":
                        oneMonthCost = 18.99;
                        break;
                    case "Large":
                        oneMonthCost = 25.98;
                        break;
                    case "ExtraLarge":
                        oneMonthCost = 35.99;
                        break;
                }
            }
            else
            {
                switch (contractType)
                {
                    case "Small":
                        oneMonthCost = 8.58;
                        break;
                    case "Middle":
                        oneMonthCost = 17.09;
                        break;
                    case "Large":
                        oneMonthCost = 23.59;
                        break;
                    case "ExtraLarge":
                        oneMonthCost = 31.79;
                        break;
                }
            }
            if (internet == "no")
            {
                internetCostForMoth = 0;
            }
            else if (oneMonthCost <= 10)
            {
                internetCostForMoth = 5.50;
            }
            else if (oneMonthCost <= 30)
            {
                internetCostForMoth = 4.35;
            }
            else
            {
                internetCostForMoth = 3.85;
            }

            double totalCost = (oneMonthCost * countMothsForPay) + (internetCostForMoth * countMothsForPay);

            if (contractPeriod == "two")
            {
                totalCost -= totalCost * 0.0375;
            }
            Console.WriteLine($"{totalCost:f2} lv.");
        }
    }
}
