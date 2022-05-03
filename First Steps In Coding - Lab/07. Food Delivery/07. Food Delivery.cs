using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Food_Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int chikenMenuCount = int.Parse(Console.ReadLine());
            int fishMenuCount = int.Parse(Console.ReadLine());
            int vegetarianMenuCount = int.Parse(Console.ReadLine());

            double sumForTheMenu = chikenMenuCount * 10.35 + fishMenuCount * 12.40 + vegetarianMenuCount * 8.15;
            double desertPrice = sumForTheMenu * 0.20;
            double totalSum = sumForTheMenu + 2.50 + desertPrice;
            Console.WriteLine(totalSum);
        }
    }
}
