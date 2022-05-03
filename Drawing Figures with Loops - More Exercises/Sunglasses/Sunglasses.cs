using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            Console.Write(new string('*' , num * 2));
            Console.Write(new string(' ', num ));
            Console.Write(new string('*', num * 2));
            Console.WriteLine();

            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("*");
                Console.Write(new string('/', num * 2 - 2));
                Console.Write("*");
                if (i == ((num - 1)/2 - 1))
                {
                    Console.Write(new string('|', num));
                }
                else
                {
                    Console.Write(new string(' ', num));
                }
                
                Console.Write("*");
                Console.Write(new string('/', num * 2 - 2));
                Console.WriteLine("*");
            }

            Console.Write(new string('*', num * 2));
            Console.Write(new string(' ', num));
            Console.WriteLine(new string('*', num * 2));
        }
    }
}
