using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Game_Number_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstPlayer = Console.ReadLine();
            string secondPlayer = Console.ReadLine();

            string firstPlayerCard = Console.ReadLine();
            string secondPlayerCard = "";

            int firstPlayerPoints = 0;
            int secondPlayerPoints = 0;

            while (firstPlayerCard != "End of game")
            {
                secondPlayerCard = Console.ReadLine();
                int firstPlayerCardPoint = int.Parse(firstPlayerCard);
                int secondPlayerCardPoint = int.Parse(secondPlayerCard);
                if (firstPlayerCardPoint > secondPlayerCardPoint)
                {
                    firstPlayerPoints += (firstPlayerCardPoint - secondPlayerCardPoint);
                }
                else if (secondPlayerCardPoint > firstPlayerCardPoint)
                {
                    secondPlayerPoints += (secondPlayerCardPoint - firstPlayerCardPoint);
                }
                else if (firstPlayerCardPoint == secondPlayerCardPoint)
                {
                    Console.WriteLine("Number wars!");
                    firstPlayerCard = Console.ReadLine();
                    secondPlayerCard = Console.ReadLine();
                    firstPlayerCardPoint = int.Parse(firstPlayerCard);
                    secondPlayerCardPoint = int.Parse(secondPlayerCard);
                    if (firstPlayerCardPoint > secondPlayerCardPoint)
                    {
                        Console.WriteLine($"{firstPlayer} is winner with {firstPlayerPoints} points");
                    }
                    else if (secondPlayerCardPoint > firstPlayerCardPoint)
                    {
                        Console.WriteLine($"{secondPlayer} is winner with {secondPlayerPoints} points");
                    }
                    return;
                }

                firstPlayerCard = Console.ReadLine();
                
            }

            Console.WriteLine($"{firstPlayer} has {firstPlayerPoints} points");
            Console.WriteLine($"{secondPlayer} has {secondPlayerPoints} points");
        }
    }
}
