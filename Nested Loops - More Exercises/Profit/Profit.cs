using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            int oneLevCount = int.Parse(Console.ReadLine());
            int twoLevsCount = int.Parse(Console.ReadLine());
            int fiveLevsCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            int oneLev = 1;
            int twoLevs = 2;
            int fiveLevs = 5;

            for (int i = 0; i <= oneLevCount; i++)
            {
                for (int j = 0; j <= twoLevsCount; j++)
                {
                    for (int k = 0; k <= fiveLevsCount; k++)
                    {
                        int totalOneLevs = i * 1;
                        int totalTwoLevs = j * 2;
                        int totalFiveLevs = k * 5;
                        int totalSum = (totalOneLevs + totalTwoLevs + totalFiveLevs);

                        if ((totalSum == sum))
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }
        }
    }
}
