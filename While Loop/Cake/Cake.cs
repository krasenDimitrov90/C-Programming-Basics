using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());// lenght of the cake
            int b = int.Parse(Console.ReadLine());// width

            int peices = a * b;
            string command = Console.ReadLine();

            while (command != "STOP")
            {
                int takePeices = int.Parse(command);
                peices -= takePeices;

                if (peices <= 0)
                {
                    break;
                }
                
                command = Console.ReadLine();

            }
            if (peices <= 0)
            {
                peices = Math.Abs(peices);
                Console.WriteLine($"No more cake left! You need {peices} pieces more.");
            }
            else
            {
                Console.WriteLine($"{peices} pieces are left.");
            }
        }
    }
}
