using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mountain_Run
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());// World record in seconds
            double distance = double.Parse(Console.ReadLine());// Distance for climbing
            double secPerMiter = double.Parse(Console.ReadLine());// Seconds for 1 miter

            // For every 50 miters , slowdown with 30 seconds.

            double totalTime = distance * secPerMiter;
            int slowdown = 0;

            for (int i = 1; i <= distance; i++)
            {
                if (i % 50 == 0)
                {
                    slowdown++;
                }
            }
            totalTime = totalTime + slowdown * 30;

            if (totalTime < record)
            {
                Console.WriteLine($" Yes! The new record is {totalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No! He was {totalTime - record:f2} seconds slower.");
            }


        }
    }
}
