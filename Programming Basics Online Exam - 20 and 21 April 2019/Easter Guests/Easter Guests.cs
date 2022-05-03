using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Guests
{
    class Program
    {
        static void Main(string[] args)
        {
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double eastPrice = 4;
            double eggPrice = 0.45;

            double eastBread = Math.Ceiling(guests / 3.0);
            int eggs = guests * 2;

            double total = (eastBread * eastPrice) +  (eggs * eggPrice);

            if (total <= budget)
            {
                Console.WriteLine($"Lyubo bought {eastBread} Easter bread and {eggs} eggs.");
                Console.WriteLine($"He has {budget - total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total - budget:f2} lv. more.");
            }



        }
    }
}
