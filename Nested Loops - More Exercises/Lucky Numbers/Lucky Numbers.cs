using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int N = int.Parse(Console.ReadLine());// N number from 1 to 10
            // Make a 4 digit number which is made by the N number
            for (int i = 1; i <= N; i++)
            {
                if (i >= 10)
                {
                    continue;
                }
                for (int j = 1; j <= N; j++)
                {
                    if (j >= 10)
                    {
                        continue;
                    }
                    for (int k = 1; k <= N; k++)
                    {
                        if (k >= 10)
                        {
                            continue;
                        }
                        for (int l = 1; l <= N; l++)
                        {
                            if (l >= 10)
                            {
                                continue;
                            }
                            if (i + j == k + l && 
                                N % (i + j) == 0 )
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                            }
                        }
                    }
                }
            }

            // the sum of first 2 numbers must be = to the sum of second 2 numbers
            // N divided by the sum of first two numbers must be without a remainder


        }
    }
}
