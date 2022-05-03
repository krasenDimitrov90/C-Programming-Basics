using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Football_Tournament
{
    class Program
    {
        static void Main(string[] args)
        {
            string futballTeam = Console.ReadLine();
            int countMathes = int.Parse(Console.ReadLine());
            int result = 0;
            int counterW = 0;
            int counterD = 0;
            int counterL = 0;

            if (countMathes == 0)
            {
                Console.WriteLine($"{futballTeam} hasn't played any games during this season.");
                return;
            }

            for (int i = 1; i <= countMathes; i++)
            {
                char statusOfGame = char.Parse(Console.ReadLine());
                if (statusOfGame == 'W')
                {
                    result += 3;
                    counterW++;
                }
                else if (statusOfGame == 'D')
                {
                    result += 1;
                    counterD++;
                }
                else if (statusOfGame == 'L')
                {
                    result += 0;
                    counterL++;
                }
            }

            double winRate = (1.0 * counterW / countMathes) * 100;
            Console.WriteLine($"{futballTeam} has won {result} points during this season.");
            Console.WriteLine("Total stats:");
            Console.WriteLine($"## W: {counterW}");
            Console.WriteLine($"## D: {counterD}");
            Console.WriteLine($"## L: {counterL}");
            Console.WriteLine($"Win rate: {winRate:f2}%");
        }
    }
}
