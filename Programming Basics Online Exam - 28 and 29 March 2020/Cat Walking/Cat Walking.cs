using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat_Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int minPerDay = int.Parse(Console.ReadLine()); // minutes of walk per 1 day
            int walksPerDay = int.Parse(Console.ReadLine());// count of walks per 1 day
            int caloriesPerDay = int.Parse(Console.ReadLine());// calories burned for 1 minute

            // For every walk , she takes equal amount of time (minutes).

            int walkingTime = minPerDay * walksPerDay;

            double burnCalories = walkingTime * 5.00;

            if (burnCalories  >= caloriesPerDay * 0.5)
            {
                Console.WriteLine($"Yes, the walk for your cat is enough. Burned calories per day: {burnCalories}.");
            }
            else
            {
                Console.WriteLine($"No, the walk for your cat is not enough. Burned calories per day: {burnCalories}.");
            }
        }
    }
}
