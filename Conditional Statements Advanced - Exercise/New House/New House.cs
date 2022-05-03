using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_House
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfFlower = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            
            double price = 0.0;

            switch (typeOfFlower)
            {
                case "Roses":
                    price = count * 5.00;
                    if (count > 80)
                    {
                        price = price - price * 0.10; 
                    }
                    
                    break;
                case "Dahlias":
                    price = count * 3.80;
                    if (count > 90)
                    {
                        price = price - price *0.15;
                    }
                    
                    break;
                case "Tulips":
                    price = count * 2.80;
                    if (count > 80)
                    {
                        price = price - price * 0.15;
                    }
                    
                    break;
                case "Narcissus":
                    price = count * 3.00;
                    if (count < 120)
                    {
                        price = price * 1.15;
                    }
                    
                    break;
                case "Gladiolus":
                    price = count * 2.50;
                    if (count < 80)
                    {
                        price = price * 1.20;
                    }
                    break;

            }

            if (budget >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {typeOfFlower} and {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {price - budget:f2} leva more.");
            }

        }
        
    }
}
