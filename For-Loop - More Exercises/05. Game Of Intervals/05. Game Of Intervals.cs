using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Game_Of_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            // От 0 до 9  20 % от числото
            // От 10 до 19  30 % от числото
            // От 20 до 29  40 % от числото
            // От 30 до 39  50 точки
            // От 40 до 50  100 точки
            // Невалидно число  резултата се дели на 2

            double counterOne = 0;
            double counterTwo = 0;
            double counterThree = 0;
            double counterFour = 0;
            double counterFive = 0;
            double counterInvalid = 0;

            double totalPoints = 0;

            int countOfTurns = int.Parse(Console.ReadLine());

            for (int i = 1; i <= countOfTurns; i++)
            {
                int turnPoints = int.Parse(Console.ReadLine());

                if (turnPoints < 0 || turnPoints > 50)
                {
                    counterInvalid++;
                    totalPoints /= 2.0;
                }
                else if (turnPoints <= 9)
                {
                    counterOne++;
                    totalPoints += 0.20 * turnPoints;
                }
                else if (turnPoints < 20)
                {
                    counterTwo++;
                    totalPoints += 0.30 * turnPoints;
                }
                else if (turnPoints < 30)
                {
                    counterThree++;
                    totalPoints += 0.40 * turnPoints;
                }
                else if (turnPoints < 40)
                {
                    counterFour++;
                    totalPoints += 50;
                }
                else if (turnPoints <= 50)
                {
                    counterFive++;
                    totalPoints += 100;
                }
            }

            // 1ви ред: "{Краен резултат}"
            // 2ри ред: "From 0 to 9: {процент в интервала}%"
            // 3ти ред: "From 10 to 19: {процент в интервала}%"
            // 4ти ред: "From 20 to 29: {процент в интервала}%"
            // 5ти ред: "From 30 to 39: {процент в интервала}%"
            // 6ти ред: "From 40 to 50: {процент в интервала}%"
            // 7ми ред: "Invalid numbers: {процент в интервала}%"

            Console.WriteLine($"{totalPoints:f2}");
            Console.WriteLine($"From 0 to 9: {(counterOne / countOfTurns)*100:f2}%");
            Console.WriteLine($"From 10 to 19: {(counterTwo / countOfTurns) * 100:f2}%");
            Console.WriteLine($"From 20 to 29: {(counterThree / countOfTurns)*100:f2}%");
            Console.WriteLine($"From 30 to 39: {(counterFour / countOfTurns)*100:f2}%");
            Console.WriteLine($"From 40 to 50: {(counterFive / countOfTurns)*100:f2}%");
            Console.WriteLine($"Invalid numbers: {(counterInvalid / countOfTurns)*100:f2}%");
        }
    }
}
