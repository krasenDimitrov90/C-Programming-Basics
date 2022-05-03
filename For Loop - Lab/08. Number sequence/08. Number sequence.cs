using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int maxNumber = Int32.MinValue;
            int minNumber = Int32.MaxValue;

            for (int i = 0; i < num; i++)
            {
                int Number = int.Parse(Console.ReadLine());
                if (Number > maxNumber)
                {
                    maxNumber = Number;
                }
                if (Number < minNumber)
                {
                    minNumber = Number;
                }
            }
            Console.WriteLine($"Max number: {maxNumber}");
            Console.WriteLine($"Min number: {minNumber}");
        }
    }
}
