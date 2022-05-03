using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Basketball_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int victoriesCounter = 0;
            int lossesCounter = 0;
            int matchesCounter = 0;

            while (command != "End of tournaments")
            {
                string tournamentName = command;
                int matchCount = int.Parse(Console.ReadLine());
                
                for (int i = 1; i <= matchCount; i++)
                {
                    matchesCounter++;
                    int desiGoals = int.Parse(Console.ReadLine());
                    int oponentsGoals = int.Parse(Console.ReadLine());
                    if (desiGoals > oponentsGoals)
                    {
                        victoriesCounter++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: win with {desiGoals - oponentsGoals} points.");
                    }
                    else
                    {
                        lossesCounter++;
                        Console.WriteLine($"Game {i} of tournament {tournamentName}: lost with {oponentsGoals - desiGoals} points.");
                    }

                }

                command = Console.ReadLine();
            }

            double procentOfVictories = (1.0 * victoriesCounter / matchesCounter) * 100;
            double procentOfLosses = (1.0 * lossesCounter / matchesCounter) * 100;

            Console.WriteLine($"{procentOfVictories:f2}% matches win");
            Console.WriteLine($"{procentOfLosses:f2}% matches lost");
        }
    }
}
