using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            int eastBread = int.Parse(Console.ReadLine());

            // sugar 950 gr    flour 750 gr

            double sugarPackeg = 0;
            double flourPackeg = 0;

            int sugarNeeded = 0;
            int flourNeeded = 0;

            int sugarMaxCounter = 0;
            int flourMaxCounter = 0;

            for (int i = 0; i < eastBread; i++)
            {
                int sugarQuantity = int.Parse(Console.ReadLine());
                int flourQuantity = int.Parse(Console.ReadLine());

                sugarNeeded += sugarQuantity;
                flourNeeded += flourQuantity;

                if (sugarMaxCounter < sugarQuantity)
                {
                    sugarMaxCounter = sugarQuantity;
                }
                if (flourMaxCounter < flourQuantity)
                {
                    flourMaxCounter = flourQuantity;
                }

            }

            sugarPackeg = (sugarNeeded / 950.00);
            flourPackeg = (flourNeeded / 750.00);

            Console.WriteLine($"Sugar: {Math.Ceiling(sugarPackeg)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flourPackeg)}");

            Console.WriteLine($"Max used flour is {flourMaxCounter} grams, max used sugar is {sugarMaxCounter} grams.");

        }
    }
}
