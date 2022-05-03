using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PC_Game_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            int countSoldGames = int.Parse(Console.ReadLine());

            // •	Hearthstone
            // •	Fornite
            // •	Overwatch
            // •	Others
            int counterHearthstone = 0;
            int counterFornite = 0;
            int counterOverwatch = 0;
            int counterOthers = 0;

            for (int i = 0; i < countSoldGames; i++)
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "Hearthstone":
                        counterHearthstone++;
                        break;
                    case "Fornite":
                        counterFornite++;
                        break;
                    case "Overwatch":
                        counterOverwatch++;
                        break;
                    default:
                        counterOthers++;
                        break;
                }
            }

            
            Console.WriteLine($"Hearthstone - {(1.0 * counterHearthstone / countSoldGames) * 100:f2}%");
            Console.WriteLine($"Fornite - {(1.0 * counterFornite / countSoldGames) * 100:f2}%");
            Console.WriteLine($"Overwatch - {(1.0 * counterOverwatch / countSoldGames) * 100:f2}%");
            Console.WriteLine($"Others - {(1.0 * counterOthers / countSoldGames) * 100:f2}%");
        }
    }
}
