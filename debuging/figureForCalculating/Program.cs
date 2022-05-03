using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figureForCalculating
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            // square , rectangle , cyrcle or triangle

            if (figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
            }

            else if (figure == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
            }

            else if (figure == "cyrcle")
            {
                double r = double.Parse(Console.ReadLine());
            }

            else if (figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
            }
        }
    }
}
