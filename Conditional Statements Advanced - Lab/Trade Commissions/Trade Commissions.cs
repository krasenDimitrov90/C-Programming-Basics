using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trade_Commissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sells = double.Parse(Console.ReadLine());

            //град    0 ≤ s ≤ 500    500 < s ≤ 1 000    1 000 < s ≤ 10 000     s > 10 000
            //sofia        5 %            7 %                 8 %                  12 %
            //varna        4.5 %          7.5 %               10 %                 13 %
            //plovdiv      5.5 %          8 %                 12 %                 14.5 %

            double comision = 0;
            switch (city)
            {
                case "Sofia":
                    if (sells >=0 && sells <= 500)
                    {
                        comision = 0.05;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 0.07;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 0.08;
                    }
                    else if (sells > 10000)
                    {
                        comision = 0.12;
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    break;

                case "Varna":
                    if (sells >= 0 && sells <= 500)
                    {
                        comision = 0.045;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 0.075;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 0.10;
                    }
                    else if (sells > 10000)
                    {
                        comision = 0.13;
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    
                    break;
                    
                case "Plovdiv":
                    if (sells >= 0 && sells <= 500)
                    {
                        comision = 0.055;
                    }
                    else if (sells > 500 && sells <= 1000)
                    {
                        comision = 0.08;
                    }
                    else if (sells > 1000 && sells <= 10000)
                    {
                        comision = 0.12;
                    }
                    else if (sells > 10000)
                    {
                        comision = 0.145;
                    }
                    else if (sells < 0)
                    {
                        Console.WriteLine("error");
                    }
                    
                    break;
                default:
                    Console.WriteLine("error");
                    break;
                
            }
            double totalComision = comision * sells;
            if (comision != 0)
            {
                Console.WriteLine($"{totalComision:f2}");
            }

        }
    }
}
