using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Fish_Tank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int lenght = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());

            //  обем на аквариумa: 85 * 75 * 47 = 299625 см3
            //  обем в литри: 299625 * 0.001 или  299625 / 1000 => 299.625 литра
            //  заето пространство: 17 % = 0.17
            //  нужни литри: 299.625 * (1 - 0.17) = 248.68875 литра

            double acuariumCapacity = (lenght * width * height) * 0.001;
            double litersNeeded = acuariumCapacity * (1 - (procent / 100));
            Console.WriteLine(litersNeeded);



        }
    }
}
