using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Tennis_Ranklist
{
    class Program
    {
        static void Main(string[] args)
        {
            int tournamentCount = int.Parse(Console.ReadLine());
            int startPoints = int.Parse(Console.ReadLine());
            int totalPoints = startPoints;
            int winCounter = 0;

            for (int i = 1; i <= tournamentCount; i++)
            {
                string stageResult = Console.ReadLine();

                switch (stageResult)
                {
                    case "W":
                        totalPoints += 2000;
                        winCounter++;
                        break;
                    case "F":
                        totalPoints += 1200;
                        break;
                    case "SF":
                        totalPoints += 720;
                        break;

                }
            }
            double avaregePoints = (1.0 * totalPoints - startPoints) / tournamentCount;
            double winProcent = (1.0 * winCounter / tournamentCount) * 100;

            Console.WriteLine($"Final points: {totalPoints}");
            Console.WriteLine($"Average points: {Math.Floor(avaregePoints)}");
            Console.WriteLine($"{winProcent:f2}%");
        }
    }
}
