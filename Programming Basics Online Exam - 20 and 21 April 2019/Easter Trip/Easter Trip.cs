using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Trip
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            // 21-23 март	24-27 март	28-31 март

            double price = 0;

            if (destination == "France")
            {
                if (dates == "21-23")
                {
                    price = days * 30;
                }
                else if (dates == "24-27")
                {
                    price = days * 35;
                }
                else if (dates == "28-31")
                {
                    price = days * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (dates == "21-23")
                {
                    price = days * 28;
                }
                else if (dates == "24-27")
                {
                    price = days * 32;
                }
                else if (dates == "28-31")
                {
                    price = days * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (dates == "21-23")
                {
                    price = days * 32;
                }
                else if (dates == "24-27")
                {
                    price = days * 37;
                }
                else if (dates == "28-31")
                {
                    price = days * 43;
                }
            }

            

            Console.WriteLine($"Easter trip to {destination} : {price:f2} leva.");
        }
    }
}
