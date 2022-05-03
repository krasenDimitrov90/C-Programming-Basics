using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            // season == „summer” or “winter”
            string destination = "";
            double price = 0;
            string vacationType = "";

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    price = budget * 0.30;
                    vacationType = "Camp";
                }
                else 
                {
                    price = budget * 0.70;
                    vacationType = "Hotel";
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    price = budget * 0.40;
                    vacationType = "Camp";
                }
                else
                {
                    price = budget * 0.80;
                    vacationType = "Hotel";
                }
            }
            else 
            {
                destination = "Europe";
                price = budget * 0.90;
                vacationType = "Hotel";
            }
            Console.WriteLine($"Somewhere in {destination}");
            Console.WriteLine("{0} - {1:f2}" ,vacationType ,price);
        }
    }
}
