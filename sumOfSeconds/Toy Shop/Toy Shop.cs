using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            int puzzle = int.Parse(Console.ReadLine());
            int doll = int.Parse(Console.ReadLine());
            int bear = int.Parse(Console.ReadLine());
            int minion = int.Parse(Console.ReadLine());
            int truck = int.Parse(Console.ReadLine());

            int totalArticuls = puzzle + doll + bear + minion + truck;
            double totalPrise = puzzle*2.6 + doll*3 + bear*4.1 + minion*8.2 + truck*2;

            if (totalArticuls >= 50)
            {
                totalPrise = totalPrise - totalPrise * 0.25;
            }
            totalPrise = totalPrise - totalPrise * 0.1;

            if (totalPrise >= vacation)
            {
                Console.WriteLine($"Yes! {(totalPrise - vacation):f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {(vacation - totalPrise):f2} lv needed.");
            }


        }
    }
}
