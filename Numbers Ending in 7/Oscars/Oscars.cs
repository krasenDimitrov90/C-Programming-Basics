using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            string actorsName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int numberOfJudges = int.Parse(Console.ReadLine());

            // Точките се формират от - дължината на името на оценяващия,
            // умножено по точките, които дава делено на две, + първоначалните точки. 
            // Ако точките станат >= 1250.5 програмата спира

            

            for (int i = 0; i < numberOfJudges && academyPoints <= 1250.5; i++)
            {
                string judgeName = Console.ReadLine();
                double judgePoints = double.Parse(Console.ReadLine());
                int multiplier = judgeName.Length;//числото от дължината името на съдията
                academyPoints = academyPoints + (multiplier * judgePoints) / 2;

            }
            if (academyPoints > 1250.5)
            {
                Console.WriteLine($"Congratulations, {actorsName} got a nominee for leading role with {academyPoints:f1}!");
            }
            else
            {
                double a = 1250.5 - academyPoints;
                Console.WriteLine($"Sorry, {actorsName} you need {a:f1} more!");
            }
        }
    }
}
