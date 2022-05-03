using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstMultiplier = 1;
            

            for (int f = 1; f <= 10; f++)
            {
                int secondMultiplier = 1;

                for (int s = 1; s <= 10; s++)
                {
                    int sum = firstMultiplier * secondMultiplier;
                    Console.WriteLine($"{firstMultiplier} * {secondMultiplier} = {sum}");
                    secondMultiplier++;
                }
                firstMultiplier++;
            }
        }
    }
}
