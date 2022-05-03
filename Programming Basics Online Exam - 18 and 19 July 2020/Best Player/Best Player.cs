using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Best_Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePlayer = Console.ReadLine();

            string bestPlayer = "";
            int mostGoals = 0;

            bool hatTrick = false;

            while (namePlayer != "END")
            {
                hatTrick = false;
                int goals = int.Parse(Console.ReadLine());

                if (goals >= 3)
                {
                    hatTrick = true;
                }

                if (mostGoals < goals)
                {
                    bestPlayer = namePlayer;
                    mostGoals = goals;
                }
                if (goals >= 10)
                {
                    bestPlayer = namePlayer;
                    mostGoals = goals;
                    break;
                }

                namePlayer = Console.ReadLine();

            }

            Console.WriteLine($"{bestPlayer} is the best player!");

            if (hatTrick)
            {
                Console.WriteLine($"He has scored {mostGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {mostGoals} goals.");
            }
        }
    }
}
