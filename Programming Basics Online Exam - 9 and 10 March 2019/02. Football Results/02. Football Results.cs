using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Football_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstMatchResult = Console.ReadLine();
            string secondMatchResult = Console.ReadLine();
            string tirthMatchResult = Console.ReadLine();

            int firstMatchTeamGoals = firstMatchResult[0];
            int firstMatchCompetitorGoals = firstMatchResult[2];

            int secondMatchTeamGoals = secondMatchResult[0];
            int secondMatchCompetitorGoals = secondMatchResult[2];

            int tirthMatchTeamGoals = tirthMatchResult[0];
            int tirthMatchCompetitorGoals = tirthMatchResult[2];

            int wonCounter = 0;
            int lostCounter = 0;
            int drawnCounter = 0;

            if (firstMatchTeamGoals > firstMatchCompetitorGoals)
            {
                wonCounter++;
            }
            else if (firstMatchTeamGoals < firstMatchCompetitorGoals)
            {
                lostCounter++;
            }
            else if (firstMatchTeamGoals == firstMatchCompetitorGoals)
            {
                drawnCounter++;
            }

            if (secondMatchTeamGoals > secondMatchCompetitorGoals)
            {
                wonCounter++;
            }
            else if (secondMatchTeamGoals < secondMatchCompetitorGoals)
            {
                lostCounter++;
            }
            else if (secondMatchTeamGoals == secondMatchCompetitorGoals)
            {
                drawnCounter++;
            }

            if (tirthMatchTeamGoals > tirthMatchCompetitorGoals)
            {
                wonCounter++;
            }
            else if (tirthMatchTeamGoals < tirthMatchCompetitorGoals)
            {
                lostCounter++;
            }
            else if (tirthMatchTeamGoals == tirthMatchCompetitorGoals)
            {
                drawnCounter++;
            }

            Console.WriteLine($"Team won {wonCounter} games.");
            Console.WriteLine($"Team lost {lostCounter} games.");
            Console.WriteLine($"Drawn games: {drawnCounter}");


        }
    }
}
