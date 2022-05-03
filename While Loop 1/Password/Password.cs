using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();

            string rightPaswword = Console.ReadLine();
            while (rightPaswword != password)
            {
                rightPaswword = Console.ReadLine();
            }
            Console.WriteLine($"Welcome {username}!");
        }
    }
}
