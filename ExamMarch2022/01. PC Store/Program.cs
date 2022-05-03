using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.PC_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double CPUPrice = double.Parse(Console.ReadLine());
            double GPUPrice = double.Parse(Console.ReadLine());
            double RAMPrice = double.Parse(Console.ReadLine());
            double countRAM = double.Parse(Console.ReadLine());
            double procentOfDiscount = double.Parse(Console.ReadLine());

            CPUPrice -= CPUPrice * procentOfDiscount;
            GPUPrice -= GPUPrice * procentOfDiscount;
            RAMPrice = RAMPrice * countRAM;
            double totalPrice = (CPUPrice + GPUPrice + RAMPrice) * 1.57;
            Console.WriteLine($"Money needed - {totalPrice:f2} leva.");
        }
    }
}
