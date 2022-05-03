using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            while (name != "End")
            {
                Console.WriteLine(name);
                name = Console.ReadLine();

            }
        }
    }
}
