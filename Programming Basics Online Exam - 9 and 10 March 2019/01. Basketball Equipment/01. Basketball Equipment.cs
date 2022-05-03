using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTaxForTraining = int.Parse(Console.ReadLine());

            double shoesPrice = yearTaxForTraining * 0.60;
            double outfitPrice = shoesPrice * 0.80;
            double ballPrice = outfitPrice / 4;
            double accessories = ballPrice / 5;
            double totalPriceForAll = yearTaxForTraining + shoesPrice + outfitPrice + ballPrice + accessories;
            Console.WriteLine($"{totalPriceForAll:f2}");
        }
    }
}
