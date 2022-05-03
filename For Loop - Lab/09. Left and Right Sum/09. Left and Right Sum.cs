using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int firstSum = 0;
            int secondSum = 0;
            // int firstSumCounter = 0;
            // int secondSumCounter = 0;

            for (int i = 1; i <= num * 2; i++)
            {
                int N = int.Parse(Console.ReadLine());

                if (i <= num)
                {
                    firstSum += N;
                }
                else
                {
                    secondSum += N;
                }
            }
            if (firstSum == secondSum)
            {
                Console.WriteLine($"Yes, sum = {firstSum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(firstSum - secondSum)}");
            }
        }
    }
}
