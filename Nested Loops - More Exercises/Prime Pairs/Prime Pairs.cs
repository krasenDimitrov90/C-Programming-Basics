using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Pairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int startFirstPairNumber = int.Parse(Console.ReadLine());
            int startSecondPairNumber = int.Parse(Console.ReadLine());
            int endFirstPairNumber = int.Parse(Console.ReadLine());
            int endSecondPairNumber = int.Parse(Console.ReadLine());

            endFirstPairNumber += startFirstPairNumber;
            endSecondPairNumber += startSecondPairNumber;

            bool firstPairPrime = true;
            bool secondPairPrime = true;

            for (int i = startFirstPairNumber; i <= endFirstPairNumber; i++)
            {
                for (int j = startSecondPairNumber; j <= endSecondPairNumber; j++)
                {
                    for (int k = 2; k < i; k++)
                    {
                        if (i % k == 0 && i != 2)
                        {
                            firstPairPrime = false;
                            break;
                        }
                    }
                    for (int l = 2; l < j; l++)
                    {
                        if (j % l == 0 && j != 2)
                        {
                            secondPairPrime = false;
                            break;
                        }
                    }

                    if (firstPairPrime && secondPairPrime)
                    {
                        Console.WriteLine($"{i}{j}");
                    }
                    firstPairPrime = true;
                    secondPairPrime = true;
                }
            }
        }
    }
}
