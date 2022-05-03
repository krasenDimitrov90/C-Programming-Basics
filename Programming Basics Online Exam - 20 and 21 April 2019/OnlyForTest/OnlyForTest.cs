using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlyForTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int current = 1;
            bool isCurrent = false;

            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = 1; j < i; j++)
                {
                    if (current > 5)
                    {
                        isCurrent = true;
                        break;
                    }
                    Console.Write(current + " ");
                    current++;

                }
                if (current > 5)
                {
                    isCurrent = true;
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
