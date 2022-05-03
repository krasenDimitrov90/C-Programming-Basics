using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Dishwasher
{
    class Program
    {
        static void Main(string[] args)
        {
            int washerBottles = int.Parse(Console.ReadLine());
            double liquidForWashing = 750 * washerBottles;
            string dishes = Console.ReadLine();
            int counter = 1;
            int cleanDishes = 0;
            int cleanPots = 0;

            while (dishes != "End" && liquidForWashing >= 0)
            {
                int countOfDishes = int.Parse(dishes);
                if (counter % 3 != 0)
                {
                    liquidForWashing -= countOfDishes * 5;
                    cleanDishes += countOfDishes;
                }
                else
                {
                    liquidForWashing -= countOfDishes * 15;
                    cleanPots += countOfDishes;
                }
                counter++;
                dishes = Console.ReadLine();

            }
            if (liquidForWashing >= 0)
            {
                Console.WriteLine("Detergent was enough!");
                Console.WriteLine($"{cleanDishes} dishes and {cleanPots} pots were washed.");
                Console.WriteLine($"Leftover detergent {liquidForWashing} ml.");
            }
            else
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(liquidForWashing)} ml. more necessary!");
            }
        }
    }
}
