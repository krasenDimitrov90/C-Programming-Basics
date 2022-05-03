using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_the_Wedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menCount = int.Parse(Console.ReadLine());
            int womenCount = int.Parse(Console.ReadLine());
            int tables = int.Parse(Console.ReadLine());

            int tableCounter = 0;

            for (int i = 1; i <= menCount; i++)
            {
                for (int j = 1; j <= womenCount; j++)
                {
                    tableCounter++;
                    if (tableCounter > tables)
                    {
                        return;
                    }
                    Console.Write($"({i} <-> {j}) ");
                }
            }
        }
    }
}
