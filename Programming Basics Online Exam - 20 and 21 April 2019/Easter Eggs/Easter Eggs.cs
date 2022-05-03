using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            int eggsCount = int.Parse(Console.ReadLine());

            //"red", "orange", "blue", "green"

            int redCount = 0;
            int orangeCount = 0;
            int blueCount = 0;
            int greenCount = 0;

            while (eggsCount >= 0)
            {
                string eggColor = Console.ReadLine();

                if (eggColor == "red")
                {
                    redCount++;
                }
                else if (eggColor == "orange")
                {
                    orangeCount++;
                }
                else if (eggColor == "blue")
                {
                    blueCount++;
                }
                else if (eggColor == "green")
                {
                    greenCount++;
                }
                eggsCount--;
                if (eggsCount == 0)
                {
                    break;
                }
            }
            
            Console.WriteLine($"Red eggs: {redCount}");
            Console.WriteLine($"Orange eggs: {orangeCount}");
            Console.WriteLine($"Blue eggs: {blueCount}");
            Console.WriteLine($"Green eggs: {greenCount}");

            if (redCount > orangeCount && redCount > blueCount && redCount > greenCount)
            {
                Console.WriteLine($"Max eggs: {redCount} -> red");
            }
            else if (orangeCount > redCount && orangeCount > blueCount && orangeCount > greenCount)
            {
                Console.WriteLine($"Max eggs: {orangeCount} -> orange");
            }
            else if (blueCount > redCount && blueCount > orangeCount && blueCount > greenCount)
            {
                Console.WriteLine($"Max eggs: {blueCount} -> blue");
            }
            else if (greenCount > redCount && greenCount > orangeCount && greenCount > blueCount)
            {
                Console.WriteLine($"Max eggs: {greenCount} -> green");
            }


        }
    }
}
