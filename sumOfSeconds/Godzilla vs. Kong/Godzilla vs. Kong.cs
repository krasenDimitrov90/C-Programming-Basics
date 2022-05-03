using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Godzilla_vs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int statist = int.Parse(Console.ReadLine());
            double clouth = double.Parse(Console.ReadLine());

            double decor = 0.1 * budget;
            double clouthPrise = clouth * statist;

            if (statist >= 150)
            {
                clouthPrise = clouthPrise - clouthPrise * 0.1;
            }

            if (budget >= decor + clouthPrise)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - (decor + clouthPrise)):f2} leva left.");
            }
            else
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {((decor + clouthPrise) - budget):f2} leva more.");
            }
        }
    }
}
