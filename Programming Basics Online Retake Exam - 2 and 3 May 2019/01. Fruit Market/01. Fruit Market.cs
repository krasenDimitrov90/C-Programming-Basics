using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fruit_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            double berryPrice = double.Parse(Console.ReadLine());
            double bananaCount = double.Parse(Console.ReadLine());
            double orangeCount = double.Parse(Console.ReadLine());
            double raspberriesCount = double.Parse(Console.ReadLine());
            double berryCount = double.Parse(Console.ReadLine());

            // •	цената на малините е на половина по - ниска от тази на ягодите;
            // •	цената на портокалите е с 40 % по - ниска от цената на малините;
            // •	цената на бананите е с 80 % по - ниска от цената на малините.

            double raspberriePrice = berryPrice * 0.50;
            double orangePrice = raspberriePrice - raspberriePrice * 0.40;
            double bananaPrice = raspberriePrice - raspberriePrice * 0.80;

            double berryTotal = berryPrice * berryCount;
            double bananaTotal = bananaPrice * bananaCount;
            double orangeTotal = orangePrice * orangeCount;
            double raspberrieTotal = raspberriePrice * raspberriesCount;
            double sum = berryTotal + bananaTotal + orangeTotal + raspberrieTotal;
            Console.WriteLine($"{sum:f2}");
        }
    }
}
