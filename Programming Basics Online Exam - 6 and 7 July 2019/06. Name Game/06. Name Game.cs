using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Name_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            
            int higherResult = 0;
            string bestPlayer = "";

            while (playerName != "Stop")
            {
                int playerNameLenght = playerName.Length;
                int result = 0;

                for (int i = 0; i < playerNameLenght; i++)
                {
                    int num = int.Parse(Console.ReadLine());
                    char symbol = playerName[i];
                    int symbolAsNUmber = symbol;
                    if (num == symbolAsNUmber)
                    {
                        result += 10;
                    }
                    else
                    {
                        result += 2;
                    }
                }
                if (higherResult <= result)
                {
                    higherResult = result;
                    bestPlayer = playerName;
                }

                playerName = Console.ReadLine();
            }

            Console.WriteLine($"The winner is {bestPlayer} with {higherResult} points!");
        }
    }
}
