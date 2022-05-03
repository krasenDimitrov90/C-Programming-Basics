using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.The_Most_Powerful_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            double biggestSum = 0;
            string powerfullWord = "";

            while (word != "End of words")
            {
                double wordLenght = word.Length;
                char firstSymbol = word[0];
                double sumOfSymbols = 0;
                for (int i = 0; i < wordLenght; i++)
                {
                    char symbol = word[i];
                    int symbolAsNumber = symbol;
                    sumOfSymbols += symbolAsNumber;
                    
                }
                switch (firstSymbol)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                    case 'y':

                    case 'A':
                    case 'E':
                    case 'I':
                    case 'O':
                    case 'U':
                    case 'Y':
                        sumOfSymbols *= wordLenght;
                        break;
                    default:
                        sumOfSymbols = Math.Floor(sumOfSymbols / wordLenght);
                        break;
                }
                if (biggestSum < sumOfSymbols)
                {
                    biggestSum = sumOfSymbols;
                    powerfullWord = word;
                }

                word = Console.ReadLine();
            }

            Console.WriteLine($"The most powerful word is {powerfullWord} - {biggestSum}");
        }
    }
}
