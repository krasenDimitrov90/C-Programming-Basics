using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int textLenght = text.Length;

            for (int i = 0; i < textLenght; i++)
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}
