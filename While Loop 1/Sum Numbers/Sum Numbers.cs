using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int sum = 0;
            while (sum < number)
            {
                int numberForSum = int.Parse(Console.ReadLine());
                sum += numberForSum;
            }
            Console.WriteLine(sum);
        }
    }
}
