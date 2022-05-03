using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_song_of_the_wheels
{
    class Program
    {
        static void Main(string[] args)
        {
            int specialNumber = int.Parse(Console.ReadLine());
            int passwordGues = 0;
            int password = 0;
            bool passwordFound = false;
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <= 9; j++)
                {
                    for (int k = 1; k <= 9; k++)
                    {
                        for (int l = 1; l <= 9; l++)
                        {
                            int sumOfAllNumbers = (i * j) + (k * l);

                            if (i < j && k > l && sumOfAllNumbers == specialNumber)
                            {
                                Console.Write($"{i}{j}{k}{l} ");
                                passwordGues++;
                                if (passwordGues == 4)
                                {
                                    passwordFound = true;
                                    password = Convert.ToInt32(string.Format($"{i}{j}{k}{l}"));
                                }
                            }


                        }
                    }
                }
            }
            Console.WriteLine();

            if (passwordFound)
            {
                Console.WriteLine($"Password: {password}");
            }
            else
            {
                Console.WriteLine("No!");
            }
        }
    }
}
