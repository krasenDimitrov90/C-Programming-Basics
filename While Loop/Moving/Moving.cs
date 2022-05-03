using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());// width
            int b = int.Parse(Console.ReadLine());// lenght
            int c = int.Parse(Console.ReadLine());// height

            int capacity = a * b * c;

            string command = Console.ReadLine();

            while (command != "Done")
            {
                int commandAsNumber = int.Parse(command);
                capacity -= commandAsNumber;
                if (capacity <= 0)
                {
                    break;
                }
                command = Console.ReadLine();
            }
            if (capacity >= 0)
            {
                Console.WriteLine($"{capacity} Cubic meters left.");
            }
            else
            {
                capacity = Math.Abs(capacity);
                Console.WriteLine($"No more free space! You need {capacity} Cubic meters more.");
            }
        }
    }
}
