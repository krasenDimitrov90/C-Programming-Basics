using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int leftDash = (num - 1) / 2;
            int rightDash = (num - 1) / 2;
            int middleDash = 0;

            for (int i = 0; i < ((num + 1 ) / 2); i++)
            {
                middleDash = num - (leftDash + rightDash + 2);
                if (middleDash < 0)
                {
                    middleDash = 0;
                }
                Console.Write(new string ('-', leftDash));
                if (middleDash <= 0)
                {
                    Console.Write("*");
                    if (num % 2 ==0)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string ('-', middleDash));
                    Console.Write("*");
                }
                Console.Write(new string('-', rightDash));
                Console.WriteLine();
                leftDash--;
                rightDash--;
            }
            leftDash = 1;
            rightDash = 1;
            for (int i = 0; i < (num - 1) / 2; i++)
            {
                middleDash = num - (leftDash + rightDash + 2);
                Console.Write(new string('-', leftDash));
                if (middleDash < 0)
                {
                    middleDash = 0;
                }
                if (middleDash <= 0)
                {
                    Console.Write("*");
                    if (num % 2 == 0)
                    {
                        Console.Write("*");
                    }
                }
                else
                {
                    Console.Write("*");
                    Console.Write(new string('-', middleDash));
                    Console.Write("*");
                }

                Console.Write(new string('-', rightDash));
                Console.WriteLine();
                leftDash++;
                rightDash++;
            }
        }
    }
}
