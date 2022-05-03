using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Frame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           
            for (int i = 1; i <= 1; i++)
            {
                Console.Write("+ ");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
            }
            

            for (int i = 0; i < num - 2; i++)
            {
                Console.Write("| ");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            
            for (int i = 1; i <= 1; i++)
            {
                Console.Write("+ ");
                for (int j = 0; j < num - 2; j++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("+");
            }
           
        }
    }
}
