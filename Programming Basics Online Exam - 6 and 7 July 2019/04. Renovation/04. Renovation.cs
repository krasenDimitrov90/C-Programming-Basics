using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallsHeight = int.Parse(Console.ReadLine());
            int wallsWidth = int.Parse(Console.ReadLine());
            int procentOfNotForPaintArea = int.Parse(Console.ReadLine());
            double areaForPainting = wallsHeight * wallsWidth * 4;
            areaForPainting = Math.Ceiling(areaForPainting - (areaForPainting * (procentOfNotForPaintArea / 100.0)));
            int paintLiters = 0;
            double leftPint = 0;

            string command = Console.ReadLine();

            while (command != "Tired!")
            {
                paintLiters = int.Parse(command);
                leftPint = paintLiters - areaForPainting;
                areaForPainting -= paintLiters;
                if (areaForPainting <= 0)
                {
                    break;
                }

                command = Console.ReadLine();
                if (command == "Tired!")
                {
                    Console.WriteLine($"{areaForPainting} quadratic m left.");
                    return;
                }
            }

            
            if (leftPint > 0)
            {
                Console.WriteLine($"All walls are painted and you have {leftPint} l paint left!");
            }
            else if (leftPint == 0)
            {
                Console.WriteLine($"All walls are painted! Great job, Pesho!");
            }

        }
    }
}
