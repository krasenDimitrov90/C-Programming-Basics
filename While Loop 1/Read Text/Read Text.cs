using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Read_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            while (command != "Stop")
            {
                Console.WriteLine(command);
                command = Console.ReadLine();
            }
        }
    }
}
