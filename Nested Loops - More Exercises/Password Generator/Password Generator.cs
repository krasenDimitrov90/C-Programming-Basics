using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSecondAndLastSymbols = int.Parse(Console.ReadLine());
            int middleTwoSymbols = int.Parse(Console.ReadLine());

            int latinIndex = middleTwoSymbols + 96;

            for (int i = 1; i <= firstSecondAndLastSymbols; i++)
            {
                for (int j = 1; j <= firstSecondAndLastSymbols; j++)
                {
                    for (int k = 97; k <= latinIndex; k++)
                    {
                        for (int l = 97; l <= latinIndex; l++)
                        {
                            for (int p = 1; p <= firstSecondAndLastSymbols; p++)
                            {
                                char firstmiddle = (char)k;
                                char secondmiddle = (char)l;
                                if (p > i && p > j)
                                {
                                    Console.Write($"{i}{j}{firstmiddle}{secondmiddle}{p} ");
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
