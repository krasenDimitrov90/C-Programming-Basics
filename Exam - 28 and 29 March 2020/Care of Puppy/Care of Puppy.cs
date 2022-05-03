using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Care_of_Puppy
{
    class Program
    {
        static void Main(string[] args)
        {
            int food = int.Parse(Console.ReadLine());
            string command = "";

            food = food * 1000;

            while (command != "Adopted")
            {
                command = Console.ReadLine();
                if (command != "Adopted")
                {
                    int foodDay = int.Parse(command);
                    food -= foodDay;
                }
                else
                {
                    break;
                }
            }
            if (food >= 0)
            {
                Console.WriteLine($"Food is enough! Leftovers: {food} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {Math.Abs(food)} grams more.");
            }
        }
    }
}
