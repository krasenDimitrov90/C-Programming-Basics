using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Repainting
{
    class Program
    {
        static void Main(string[] args)
        {
            int nylonSqrtMeters = int.Parse(Console.ReadLine());
            int paintLiters = int.Parse(Console.ReadLine());
            int thinnerLiters = int.Parse(Console.ReadLine());
            int hoursForWork = int.Parse(Console.ReadLine());

            // Предпазен найлон -1.50 лв.за кв. метър
            // Боя - 14.50 лв.за литър
            // Разредител за боя - 5.00 лв.за литър

            double nylonPrice = (nylonSqrtMeters + 2) * 1.50;
            double paintPrice = (paintLiters * 1.1) * 14.50;
            double thinnerPrice = thinnerLiters * 5.00;
            double sumForAllMaterials = nylonPrice + paintPrice + thinnerPrice + 0.40;
            double payForWorkers = (sumForAllMaterials * 0.30) * hoursForWork;
            double totalSumForAll = sumForAllMaterials + payForWorkers;
            Console.WriteLine(totalSumForAll);


        }
    }
}
