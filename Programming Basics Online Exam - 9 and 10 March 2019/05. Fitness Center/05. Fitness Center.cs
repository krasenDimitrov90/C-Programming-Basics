using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fitness_Center
{
    class Program
    {
        static void Main(string[] args)
        {
            int visitorsCount = int.Parse(Console.ReadLine());
            int backCounter = 0;
            int chestCounter = 0;
            int legsCounter = 0;
            int absCounter = 0;
            int proteinShakeCounter = 0;
            int proteinBarCounter = 0;

            int trinigPeople = 0;
            int eatingPeople = 0;

            for (int i = 1; i <= visitorsCount; i++)
            {
                string activityType = Console.ReadLine();
                switch (activityType)
                {
                    // ", "Chest", "Legs", "Abs", "Protein shake" или "Protein bar")
                    case "Back":
                        backCounter++;
                        trinigPeople++;
                        break;
                    case "Chest":
                        chestCounter++;
                        trinigPeople++;
                        break;
                    case "Legs":
                        legsCounter++;
                        trinigPeople++;
                        break;
                    case "Abs":
                        absCounter++;
                        trinigPeople++;
                        break;
                    case "Protein shake":
                        proteinShakeCounter++;
                        eatingPeople++;
                        break;
                    case "Protein bar":
                        proteinBarCounter++;
                        eatingPeople++;
                        break;
                }
                
            }
            double avaregeTrainigPeople = (1.0 * trinigPeople / visitorsCount) * 100;
            double avaregeEatingPeople = (1.0 * eatingPeople / visitorsCount) * 100;

            Console.WriteLine($"{backCounter} - back");
            Console.WriteLine($"{chestCounter} - chest");
            Console.WriteLine($"{legsCounter} - legs");
            Console.WriteLine($"{absCounter} - abs");
            Console.WriteLine($"{proteinShakeCounter} - protein shake");
            Console.WriteLine($"{proteinBarCounter} - protein bar");
            Console.WriteLine($"{avaregeTrainigPeople:f2}% - work out");
            Console.WriteLine($"{avaregeEatingPeople:f2}% - protein");
        }
    }
}
