using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double diapason1 = 0;// < 200
            double diapason2 = 0;//   200 до 399
            double diapason3 = 0;//   400 до 599
            double diapason4 = 0;//   600 до 799
            double diapason5 = 0;//   800 нагоре

            for (int i = 0; i < n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (num < 200)
                {
                    diapason1++;
                }
                else if (num < 400 )
                {
                    diapason2++;
                }
                else if (num < 600)
                {
                    diapason3++;
                }
                else if (num < 800)
                {
                    diapason4++;
                }
                else 
                {
                    diapason5++;
                }
            }

            double p1 = diapason1 / n * 100;
            double p2 = diapason2 / n * 100;
            double p3 = diapason3 / n * 100;
            double p4 = diapason4 / n * 100;
            double p5 = diapason5 / n * 100;

            Console.WriteLine($"{p1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
