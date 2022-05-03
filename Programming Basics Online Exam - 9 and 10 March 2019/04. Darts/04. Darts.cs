using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Darts
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            string shotType = Console.ReadLine();

            int successShots = 0;
            int unsuccessShots = 0;
            int totalPoints = 301;

            while (shotType != "Retire" || totalPoints == 0)
            {
                int shotPoints = int.Parse(Console.ReadLine());
                int multiplier = 1;
                
                switch (shotType)
                {
                    case "Single":
                        multiplier = 1;
                        break;
                    case "Double":
                        multiplier = 2;
                        break;
                    case "Triple":
                        multiplier = 3;
                        break;
                }
                shotPoints *= multiplier;
                if (totalPoints - shotPoints < 0)
                {
                    unsuccessShots++;
                }
                else
                {
                    totalPoints -= shotPoints;
                    successShots++;
                }
                if (totalPoints == 0)
                {
                    break;
                }
                
                shotType = Console.ReadLine();
            }

            if (shotType == "Retire")
            {
                Console.WriteLine($"{playerName} retired after {unsuccessShots} unsuccessful shots.");
            }
            else
            {
                Console.WriteLine($"{playerName} won the leg with {successShots} shots.");
            }
        }
    }
}
