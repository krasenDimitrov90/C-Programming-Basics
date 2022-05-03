using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting_Eggs
{
    class Program
    {
        static void Main(string[] args)
        {
            string eggSize = Console.ReadLine();
            string eggColor = Console.ReadLine();
            int eggCount = int.Parse(Console.ReadLine());

            //"Red", "Green" или "Yellow"

            double price = 0;

            if (eggSize == "Large")
            {
                if (eggColor == "Red")
                {
                    price = eggCount * 16;
                }
                else if (eggColor == "Green")
                {
                    price = eggCount * 12;
                }
                else if (eggColor == "Yellow")
                {
                    price = eggCount * 9;
                }
            }
            else if (eggSize == "Medium")
            {
                if (eggColor == "Red")
                {
                    price = eggCount * 13;
                }
                else if (eggColor == "Green")
                {
                    price = eggCount * 9;
                }
                else if (eggColor == "Yellow")
                {
                    price = eggCount * 7;
                }
            }
            else if (eggSize == "Small")
            {
                if (eggColor == "Red")
                {
                    price = eggCount * 9;
                }
                else if (eggColor == "Green")
                {
                    price = eggCount * 8;
                }
                else if (eggColor == "Yellow")
                {
                    price = eggCount * 5;
                }
            }

            Console.WriteLine($"{price * 0.65 :f2} leva.");
        }
    }
}
