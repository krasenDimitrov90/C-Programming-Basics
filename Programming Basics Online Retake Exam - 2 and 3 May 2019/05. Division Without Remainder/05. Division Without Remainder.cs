using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Division_Without_Remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= number; i++)
            {
                int numForDividing = int.Parse(Console.ReadLine());
                if (numForDividing % 2 == 0)
                {
                    p1++;
                }
                if (numForDividing % 3 == 0)
                {
                    p2++;
                }
                if (numForDividing % 4 == 0)
                {
                    p3++;
                }

            }
            Console.WriteLine($"{(p1 / number) * 100:f2}%");
            Console.WriteLine($"{(p2 / number) * 100:f2}%");
            Console.WriteLine($"{(p3 / number) * 100:f2}%");
        }
    }
}
