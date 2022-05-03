using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Club
{
    class Program
    {
        static void Main(string[] args)
        {
            double desireIncome = double.Parse(Console.ReadLine());
            string coctailName = Console.ReadLine();
            double totalIncome = 0;
            
            

            while (coctailName != "Party!")
            {
                int coctailPrice = coctailName.Length;
                int counterCoctails = int.Parse(Console.ReadLine());
                double priceForAllCoctails = (counterCoctails * coctailPrice);

                if (priceForAllCoctails % 2 != 0)
                {
                    priceForAllCoctails -= priceForAllCoctails * 0.25;
                }

                totalIncome += priceForAllCoctails;
                if (totalIncome >= desireIncome)
                {
                    Console.WriteLine("Target acquired.");
                    break;
                }

                coctailName = Console.ReadLine();
            }
            if (coctailName == "Party!")
            {
                Console.WriteLine($"We need {desireIncome - totalIncome:f2} leva more.");
            }
            Console.WriteLine($"Club income - {totalIncome:f2} leva.");
        }
    }
}
