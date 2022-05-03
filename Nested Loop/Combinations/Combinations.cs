using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());// Number on wich we will serch all combinations


            
            
            int combination = 0;// Counter for the count of combinations

            for (int y1 = 0; y1 <= n; y1++)
            {
                
                for (int y2 = 0; y2 <= n; y2++)
                {
                    
                    for (int y3 = 0; y3 <= n; y3++)
                    {
                        if (y1 + y2 + y3 == n)
                        {
                            combination++;
                        }
                    }
                }
            }
            Console.WriteLine(combination);
        }
    }
}
