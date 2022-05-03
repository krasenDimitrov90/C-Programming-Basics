using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = 0;
            

            for (int h = 0; h <= 23; h++)
            {
                int minutes = 0;
                for (int m = 0; m <= 59; m++)
                {
                    Console.WriteLine("{0:d2}:{1:d2}", hours, minutes);
                    minutes++;
                }
                hours++;
            }
        }
    }
}
