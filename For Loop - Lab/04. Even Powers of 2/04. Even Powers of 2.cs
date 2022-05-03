using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Even_Powers_of_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = double.Parse(Console.ReadLine());
            
            
            for (int i = 0; i <= num; i++)
            {
                if (i % 2 == 0 || i == 0)
                {
                    Console.WriteLine(Math.Pow(2,i));
                }
            }
        }
    }
}
