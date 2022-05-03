using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double flourPrice = double.Parse(Console.ReadLine());

            double flourQuantity = double.Parse(Console.ReadLine());
            double sugarQuantity = double.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int maq = int.Parse(Console.ReadLine());

            double sugarPrice = 0.75 * flourPrice;
            double eggPrice = 1.10 * flourPrice;
            double maqPrice = 0.20 * sugarPrice;

            double sum = (flourPrice * flourQuantity +
                          sugarPrice * sugarQuantity +
                          eggPrice * eggs +
                          maqPrice * maq);

            Console.WriteLine($"{sum:f2}");
        }
    }
}
