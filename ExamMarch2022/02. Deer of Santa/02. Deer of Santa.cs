using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Deer_of_Santa
{
    class Program
    {
        static void Main(string[] args)
        {
            int daysOfMisingOut = int.Parse(Console.ReadLine());
            int foodLeftFromSanta = int.Parse(Console.ReadLine());
            double deer1FoodADay = double.Parse(Console.ReadLine());
            double deer2FoodADay = double.Parse(Console.ReadLine());
            double deer3FoodADay = double.Parse(Console.ReadLine());

            double foodForAllDeersForADay = deer1FoodADay + deer2FoodADay + deer3FoodADay;
            double neededFood = foodForAllDeersForADay * daysOfMisingOut;
            if (neededFood <= foodLeftFromSanta)
            {
                Console.WriteLine($"{Math.Floor(foodLeftFromSanta - neededFood)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(neededFood - foodLeftFromSanta)} more kilos of food are needed.");
            }
        }
    }
}
