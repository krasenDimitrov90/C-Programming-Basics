using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Tennis_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double rocketPrice = double.Parse(Console.ReadLine());
            int rocketCount = int.Parse(Console.ReadLine());
            int shoesCount = int.Parse(Console.ReadLine());

            double totalRocketPrice = rocketPrice * rocketCount;
            double shoesPrice = rocketPrice / 6;
            double totalShoesPrice = shoesPrice * shoesCount;
            double otherStuff = (totalRocketPrice + totalShoesPrice) * 0.20;
            double totalPRiceForAll = totalShoesPrice + totalRocketPrice + otherStuff;
            double djocovichPaid = totalPRiceForAll / 8;

            Console.WriteLine($"Price to be paid by Djokovic {Math.Floor(djocovichPaid)}");
            Console.WriteLine($"Price to be paid by sponsors {Math.Ceiling(totalPRiceForAll - djocovichPaid)}");
        }
    }
}
