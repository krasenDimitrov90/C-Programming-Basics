using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Supplies_for_School
{
    class Program
    {
        static void Main(string[] args)
        {
            int packegePen = int.Parse(Console.ReadLine());
            int packegeMarker = int.Parse(Console.ReadLine());
            int liqudLiters = int.Parse(Console.ReadLine());
            int discount = int.Parse(Console.ReadLine());

            //•	Пакет химикали -5.80 лв.
            //•	Пакет маркери -7.20 лв.
            //•	Препарат - 1.20 лв(за литър)

            double price = packegePen * 5.80 + packegeMarker * 7.20 + liqudLiters * 1.20;
            double totalPrice = price - price * (discount / 100.00);

            Console.WriteLine(totalPrice);


        }
    }
}
