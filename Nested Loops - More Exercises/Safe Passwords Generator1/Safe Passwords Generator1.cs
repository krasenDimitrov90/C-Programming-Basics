using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Safe_Passwords_Generator1
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int maxCountPasswords = int.Parse(Console.ReadLine());

            int firstSymbolNumber = 35;
            int secondSymbolNumber = 64;
            char firstSymbol = 'a';
            char secondSymbol = 'a';
            int maxPasswordsCounter = 0;

            for (int i = 1; i <= firstNumber; i++)
            {
                for (int j = 1; j <= secondNumber; j++)
                {
                    if (maxPasswordsCounter >= maxCountPasswords)
                    {
                        return;
                    }
                    
                    if (firstSymbolNumber > 55)
                    {
                        firstSymbolNumber = 35;
                    }
                    if (secondSymbolNumber > 96)
                    {
                        secondSymbolNumber = 64;
                    }

                    firstSymbol = (char)firstSymbolNumber;
                    secondSymbol = (char)secondSymbolNumber;

                    Console.Write($"{firstSymbol}{secondSymbol}{i}{j}{secondSymbol}{firstSymbol}|");
                    firstSymbolNumber++;
                    secondSymbolNumber++;
                    maxPasswordsCounter++;
                }
            }
        }
    }
}
