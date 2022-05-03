using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Gymnastics
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string divice = Console.ReadLine();

            double points = 0;

            switch (divice)
            {
                case "ribbon":
                    switch (country)
                    {
                        case "Russia":
                            points = 18.5;
                            break;
                        case "Bulgaria":
                            points = 19;
                            break;
                        case "Italy":
                            points = 18.7;
                            break;
                    }
                    break;
                case "hoop":
                    switch (country)
                    {
                        case "Russia":
                            points = 19.1;
                            break;
                        case "Bulgaria":
                            points = 19.3;
                            break;
                        case "Italy":
                            points = 18.8;
                            break;
                    }
                    break;
                case "rope":
                    switch (country)
                    {
                        case "Russia":
                            points = 18.6;
                            break;
                        case "Bulgaria":
                            points = 18.9;
                            break;
                        case "Italy":
                            points = 18.85;
                            break;
                    }
                    break;
            }

            double lackingPoints = 20 - points;
            double lackingPointsInProcent = (lackingPoints / 20) * 100;

            Console.WriteLine($"The team of {country} get {points:f3} on {divice}.");
            Console.WriteLine($"{lackingPointsInProcent:f2}%");
        }
    }
}
