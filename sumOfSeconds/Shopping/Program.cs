using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int GPU = int.Parse(Console.ReadLine());
            int CPU = int.Parse(Console.ReadLine());
            int Ram = int.Parse(Console.ReadLine());

            double GPUPrice = 250 * GPU;
            double CPUPrice = CPU * (0.35 * GPUPrice);
            double RamPrice = Ram * (0.1 * GPUPrice);


            double total = GPUPrice + CPUPrice + RamPrice;

            if (GPU > CPU)
            {
                total = total - (total * 0.15);
            }

            double diference = budget - total;

            if (diference >=0)
            {
                Console.WriteLine($"You have {((diference)):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(Math.Abs(diference)):f2} leva more!");
            }
        }
    }
}
