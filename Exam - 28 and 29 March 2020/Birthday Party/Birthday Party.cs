using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthday_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Торта  – цената ѝ е 20 % от наема на залата
            //•	Напитки – цената им е 45 % по - малко от тази на тортата
            //•	Аниматор – цената му е 1 / 3 от цената за наема на залата

            double rent = double.Parse(Console.ReadLine()); // rent for the hall

            double cakePrice = 0.20 * rent;
            double drink = cakePrice - cakePrice * 0.45;
            double animator = 1.0 / 3 * rent; // or (rent / 3)

            double sum = rent + cakePrice + drink + animator;
            Console.WriteLine(sum);
 
        }
    }
}
