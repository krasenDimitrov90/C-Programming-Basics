using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write(new string(' ', num - i));
                //Console.Write("*");
                for (int j = 0; j < i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(" ");
            }
            for (int i = 1; i <= num; i++)
            {
                Console.Write(new string(' ', i));
                for (int j = 0; j < num - i; j++)
                {
                    
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
