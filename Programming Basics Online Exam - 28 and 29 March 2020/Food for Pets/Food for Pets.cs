using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_for_Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine()); // total days 
            double foodQuantity = double.Parse(Console.ReadLine()); // total food quantity

            // For every day , read from Console , quantity eaten by the dog , and another by the cat.

            double dogEat = 0;// Total Food eaten from the dog 
            double catEat = 0; // Total Food eaten from the cat 
            double biscuits = 0;// Biscuits eaten from both

            for (int i = 1; i <= days; i++)
            {
                double dogEatDay = double.Parse(Console.ReadLine());// Food eaten from the dog for 1 day
                double catEatDay = double.Parse(Console.ReadLine());// Food eaten from the cat for 1 day
                double biscuitsDay = 0;// Biscuits eaten for a day
                // On every 3th day they get prize (biscuits) , eaqual to 10 % of the total food for
                // that day.
                if (i % 3 == 0)
                {
                    biscuitsDay = (dogEatDay + catEatDay) * 0.10;
                    biscuits += biscuitsDay;
                }

                dogEat += dogEatDay;
                catEat += catEatDay;

            }

            // Calculate how many of the total food is eaten from both - the dog and the cat. ( % )

            double totalFood = dogEat + catEat;
            // Calculate how many food is eaten by the dog. ( % )
            // Calculate how many food is eaten by the cat. ( % )
            // Calculate how many biscuits are eaten in total. (in quantity)

            biscuits = Math.Round(biscuits);

            Console.WriteLine($"Total eaten biscuits: {biscuits}gr.");
            Console.WriteLine($"{(totalFood / foodQuantity) * 100:f2}% of the food has been eaten.");
            Console.WriteLine($"{(dogEat / totalFood) * 100:f2}% eaten from the dog.");
            Console.WriteLine($"{(catEat / totalFood) * 100:f2}% eaten from the cat.");
        }
    }
}
