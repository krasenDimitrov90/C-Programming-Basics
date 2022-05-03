using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Basketball_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            int yearTaxForTrainings = int.Parse(Console.ReadLine());

            // Цена на тренировките за година: 365
            // Цена на баскетболните кецове: 365 – 40 % = 219
            // Цена на баскетболен екип: 219 – 20 % = 175.20
            // Цена на баскетболна топка: 1 / 4 от 175.20 = 43.80
            // Цена на баскетболни аксесоари: 1 / 5 от 43.80 = 8.76
            // Обща цена за екипировката: 365 + 219 + 175.20 + 43.80 + 8.76 = 811.76

            double snikersPrice = yearTaxForTrainings - yearTaxForTrainings * 0.40;
            double outfitPrice = snikersPrice - snikersPrice * 0.20;
            double ballPrice = outfitPrice / 4;
            double accessoriesPrice = ballPrice / 5;
            double totalPriceForAll = yearTaxForTrainings + snikersPrice + outfitPrice + ballPrice + accessoriesPrice;
            Console.WriteLine(totalPriceForAll);
        }
    }
}
