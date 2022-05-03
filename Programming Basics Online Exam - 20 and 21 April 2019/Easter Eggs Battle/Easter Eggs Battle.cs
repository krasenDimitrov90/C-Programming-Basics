using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Easter_Eggs_Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPlayer = int.Parse(Console.ReadLine());
            int secondPlayer = int.Parse(Console.ReadLine());

            string command = Console.ReadLine(); 

            bool firstStatement = false;
            bool secondStatement = false;

            while (command != "End of battle")
            {
                if (command == "one")
                {
                    secondPlayer--;
                }
                else if (command == "two")
                {
                    firstPlayer--;
                }
                if (firstPlayer == 0)
                {
                    firstStatement = true;
                    break;
                }
                else if (secondPlayer == 0)
                {
                    secondStatement = true;
                    break;
                }
                command = Console.ReadLine(); 
            }
            if (firstStatement)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {secondPlayer} eggs left.");
            }
            else if (secondStatement)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {firstPlayer} eggs left.");
            }
            else
            {
                Console.WriteLine($"Player one has {firstPlayer} eggs left.");
                Console.WriteLine($"Player two has {secondPlayer} eggs left.");
            }
        }
    }
}
