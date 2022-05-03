using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd__Even_Position
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            double oddSum = 0;
            double oddMin = Int32.MaxValue;
            double oddMax = Int32.MinValue;
            double evenSum = 0;
            double evenMin = Int32.MaxValue;
            double evenMax = Int32.MinValue;
            int oddCounter = 0;
            int evenCounter = 0;

            for (int i = 1; i <= N; i++)
            {
                double num = double.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    evenCounter++;
                    evenSum += num;
                    if (evenMax < num)
                    {
                        evenMax = num;
                    }
                    if (evenMin > num)
                    {
                        evenMin = num;
                    }
                }
                else
                {
                    oddCounter++;
                    oddSum += num;
                    if (oddMax < num)
                    {
                        oddMax = num;
                    }
                    if (oddMin > num)
                    {
                        oddMin = num;
                    }
                }
            }
            // "OddSum=" + { сума на числата на нечетни позиции},
            // "OddMin=" + { минимална стойност на числата на нечетни позиции } / {“No”},
            // "OddMax=" + { максимална стойност на числата на нечетни позиции } / {“No”},
            // "EvenSum=" + { сума на числата на четни позиции },
            // "EvenMin=" + { минимална стойност на числата на четни позиции } / {“No”},
            // "EvenMax=" + { максимална стойност на числата на четни позиции } / {“No”}
            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddCounter == 0)
            {
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenCounter == 0)
            {
                Console.WriteLine($"EvenMin=No,");
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }

        }
    }
}
