using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int count = 1;

            bool iscountBigger = false;

            for (int i = 1; i <= num; i++)
            {
                
                for (int y = 0; y < i; y++)
                {
                    if (count > num)
                    {
                        iscountBigger = true;
                        break;
                    }
                    Console.Write($"{count} ");
                    count++;
                }
                if (iscountBigger)
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
