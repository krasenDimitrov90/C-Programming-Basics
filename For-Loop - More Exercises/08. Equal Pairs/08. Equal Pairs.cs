using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Equal_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int maxDiff = 0;
            int diff = 0;
            int sum1 = 0;
            
            int num1 = 0;
            int num2 = 0;

            for (int i = 1; i <= n; i++)
            {
                sum1 = num1 + num2;
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                int sumpair = num1 + num2;
                //if (i == 1)
                //{
                //    //sum1 = sumpair;
                //    continue;

                //}

                diff = Math.Abs(sum1 - sumpair);
                if (maxDiff < diff)
                {
                    maxDiff = diff;
                }
                

            }
            if (diff == 0)
            {
                Console.WriteLine($"Yes, value={sum1}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDiff}");
            }


        }
    }
}
