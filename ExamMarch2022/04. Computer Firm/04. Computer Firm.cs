using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Computer_Firm
{
    class Program
    {
        static void Main(string[] args)
        {
            int countComputers = int.Parse(Console.ReadLine());
            double countSells = 0;
            double countRaiting = 0;
            for (int i = 1; i <= countComputers; i++)
            {
                string number = Console.ReadLine();
                char a = number[2];
                char b = number[1];
                char c = number[0];

                int number1 = (int)Char.GetNumericValue(a);
                int n2 = (int)Char.GetNumericValue(b);
                int n3 = (int)Char.GetNumericValue(c);

                string secoundNumber = Convert.ToString(n3);
                secoundNumber += n2;
                int number2 = Int32.Parse(secoundNumber);

                int raiting = number1;
                double sells = number2;
                switch (raiting)
                {
                    case 2:
                        sells = 0;
                        break;
                    case 3:
                        sells = sells * 0.50;
                        break;
                    case 4:
                        sells = sells * 0.70;
                        break;
                    case 5:
                        sells = sells * 0.85;
                        break;
                    case 6:
                        sells = sells * 1;
                        break;
                }
                countSells += sells;
                countRaiting += raiting;

            }

            Console.WriteLine($"{countSells:f2}");
            Console.WriteLine($"{(countRaiting / countComputers):f2}");
        }
    }
}
