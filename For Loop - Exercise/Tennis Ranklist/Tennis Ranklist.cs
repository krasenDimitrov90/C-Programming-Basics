using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine()); // брой турнири
            int startPoints = int.Parse(Console.ReadLine()); // начални точки
            // W -  ако е победител получава 2000 точки
            // F - ако е финалист получава 1200 точки
            // SF - ако е полуфиналист получава 720 точки

            int winingPoins = startPoints; // точки от победите
            int counterW = 0; // брояч победи
            for (int i = 0; i < tournamentCount; i++)
            {
                string stage = Console.ReadLine(); // достигнат етап от турнира
                if (stage == "W")
                {
                    counterW++;
                    winingPoins += 2000;
                }
                else if (stage == "F")
                {
                    winingPoins += 1200;
                }
                else if (stage == "SF")
                {
                    winingPoins += 720;
                }
            }

            double averagePoints = Math.Floor(1.0 * (winingPoins - startPoints) / tournamentCount);
            double p = 1.0 * counterW / tournamentCount * 100;

            Console.WriteLine($"Final points: {winingPoins}");
            Console.WriteLine($"Average points: {averagePoints}");
            Console.WriteLine($"{p:f2}%");

        }
    }
}
