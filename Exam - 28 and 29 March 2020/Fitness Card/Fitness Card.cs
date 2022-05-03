using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitness_Card
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            int age = int.Parse(Console.ReadLine());
            string sport = Console.ReadLine();

            //  Пол  |Gym  Boxing   Yoga  Zumba  Dances  Pilates
            //  мъж	 |$42    $41    $45    $34    $51    $39
            //  жена |$35    $37    $42    $31    $53    $37


            double totalPrice = 0;

            if (sex == 'm')
            {
                if (sport == "Gym")
                {
                    totalPrice = 42;
                }
                else if (sport == "Boxing")
                {
                    totalPrice = 41;
                }
                else if (sport == "Yoga")
                {
                    totalPrice = 45;
                }
                else if (sport == "Zumba")
                {
                    totalPrice = 34;
                }
                else if (sport == "Dances")
                {
                    totalPrice = 51;
                }
                else if (sport == "Pilates")
                {
                    totalPrice = 39;
                }
            }
            else if (sex =='f')
            {
                if (sport == "Gym")
                {
                    totalPrice = 35;
                }
                else if (sport == "Boxing")
                {
                    totalPrice = 37;
                }
                else if (sport == "Yoga")
                {
                    totalPrice = 42;
                }
                else if (sport == "Zumba")
                {
                    totalPrice = 31;
                }
                else if (sport == "Dances")
                {
                    totalPrice = 53;
                }
                else if (sport == "Pilates")
                {
                    totalPrice = 37;
                }
            }
            if (age <= 19)
            {
                totalPrice *= 0.8;
            }
            else
            {
                totalPrice = totalPrice;
            }
            if (totalPrice <= budget)
            {
                Console.WriteLine($"You purchased a 1 month pass for {sport}.");
            }
            else
            {
                Console.WriteLine($"You don't have enough money! You need ${totalPrice - budget:f2} more.");
            }
        }
    }
}
