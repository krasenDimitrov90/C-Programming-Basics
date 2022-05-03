using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int countCargo = int.Parse(Console.ReadLine());

            // •	До 3 тона – микробус(200 лева на тон)
            // •	От 4 до 11 тона – камион(175 лева на тон)
            // •	12 и повече тона – влак(120 лева на тон)

            int countMicrobus = 0;
            int countTruck = 0;
            int countTrain = 0;
            int totalTons = 0;

            int totalMicrobusPrice = 0;
            int totalTruckPrice = 0;
            int totalTrainPrice = 0;
            int totalPriceForAllCargo = 0;


            for (int i = 1; i <= countCargo; i++)
            {
                int tonsOfOneCargo = int.Parse(Console.ReadLine());

                if (tonsOfOneCargo <= 3)
                {
                    countMicrobus += tonsOfOneCargo;
                    totalMicrobusPrice += tonsOfOneCargo * 200;
                }
                else if (tonsOfOneCargo <= 11)
                {
                    countTruck += tonsOfOneCargo;
                    totalTruckPrice += tonsOfOneCargo * 175;
                }
                else
                {
                    countTrain += tonsOfOneCargo;
                    totalTrainPrice += tonsOfOneCargo * 120;
                }
            }
            totalTons = countMicrobus + countTruck + countTrain;

            totalPriceForAllCargo = totalMicrobusPrice + totalTruckPrice + totalTrainPrice;

            Console.WriteLine($"{1.0 * totalPriceForAllCargo / totalTons:f2}");
            Console.WriteLine($"{(1.0 * countMicrobus / totalTons) * 100:f2}%");
            Console.WriteLine($"{(1.0 * countTruck / totalTons) * 100:f2}%");
            Console.WriteLine($"{(1.0 * countTrain / totalTons) * 100:f2}%");
        }
    }
}
