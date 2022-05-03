using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aluminum_Joinery
{
    class Program
    {
        static void Main(string[] args)
        {
            // Размер    Единична цена        Отстъпка от цената
            // 90X130       110 лв.            Над 30 броя – 5 %
            //                                 Над 60 броя – 8 %
            // 100X150      140 лв.            Над 40 броя – 6 %
            //                                 Над 80 броя – 10 %
            // 130X180      190 лв.            Над 20 броя – 7 %
            //                                 Над 50 броя – 12 %
            // 200X300      250 лв.            Над 25 броя – 9 %
            //                                 Над 50 броя – 14 %

            int pvcCount = int.Parse(Console.ReadLine());
            string pvcType = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;

            if (pvcCount < 10)
            {
                Console.WriteLine("Invalid order");
            }
            else
            {
                if (pvcType == "90X130")
                {
                    price = 110 * pvcCount;
                    if (pvcCount > 30 && pvcCount <= 60)
                    {
                        price -= price * 0.05;
                    }
                    else if (pvcCount > 60)
                    {
                        price -= price * 0.08;
                    }
                }
                else if (pvcType == "100X150")
                {
                    price = 140 * pvcCount;
                    if (pvcCount > 40 && pvcCount <= 80)
                    {
                        price -= price * 0.06;
                    }
                    else if (pvcCount > 80)
                    {
                        price -= price * 0.10;
                    }
                }
                else if (pvcType == "130X180")
                {
                    price = 190 * pvcCount;
                    if (pvcCount > 20 && pvcCount <= 50)
                    {
                        price -= price * 0.07;
                    }
                    else if (pvcCount > 50)
                    {
                        price -= price * 0.12;
                    }
                }
                else if (pvcType == "200X300")
                {
                    price = 250 * pvcCount;
                    if (pvcCount > 25 && pvcCount <= 50)
                    {
                        price -= price * 0.09;
                    }
                    else if (pvcCount > 50)
                    {
                        price -= price * 0.14;
                    }
                }

                if (delivery == "With delivery")
                {
                    price += 60;
                }
                if (pvcCount > 99)
                {
                    price -= price * 0.04;
                }

                Console.WriteLine($"{price:f2} BGN");

            }

        }
    }
}
