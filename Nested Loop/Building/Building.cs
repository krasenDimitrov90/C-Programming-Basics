using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Program
    {
        static void Main(string[] args)
        {
            int floor = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());

            for (int i = floor; i > 0; i--)
            {
                for (int y = 0; y < rooms; y++)
                {
                    if (i == floor)
                    {
                        Console.Write($"L{i}{y} ");
                    }
                    else if (i % 2 != 0 )
                    {
                        Console.Write($"A{i}{y} ");
                    }
                    else if (i % 2 == 0)
                    {
                        Console.Write($"O{i}{y} ");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
