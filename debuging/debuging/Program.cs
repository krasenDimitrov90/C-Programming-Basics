using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debuging
{
    class Program
    {
        static void Main(string[] args)
        {
            string weather = Console.ReadLine();
            // sunny , cloudy , rayni

            if (weather == "sunny")
            {
                Console.WriteLine("Go for a walk!");
            }
            else if (weather == "cloudy")
            {
                Console.WriteLine("Take an umbrella!");

            }
            else if (weather == "rayni")
            {
                Console.WriteLine("Stay at home!");
            }
        }
    }
}
