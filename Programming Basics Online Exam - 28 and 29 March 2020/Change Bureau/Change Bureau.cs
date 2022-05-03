using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Change_Bureau
{
    class Program
    {
        static void Main(string[] args)
        {
            int bitcoinCount = int.Parse(Console.ReadLine());
            double juahn = double.Parse(Console.ReadLine());
            double comision = double.Parse(Console.ReadLine());

            double bitcoinPrice = 1168 * bitcoinCount; // lv.
            double juahnPrice = 0.15 * 1.76 * juahn; // lv.

            double eurosum = (bitcoinPrice + juahnPrice) / 1.95;
            eurosum = eurosum - eurosum * (comision / 100);

            Console.WriteLine($"{eurosum:f2}");

            
        }
    }
}
