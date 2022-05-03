using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Books
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string bookName = Console.ReadLine();

            string bookNameCounter = "";
            int counter = 0;

            while (bookNameCounter != bookName)
            {
                
                bookNameCounter = Console.ReadLine();
                if (bookNameCounter == "No More Books" || bookNameCounter == bookName)
                {
                    break;
                }
                counter++;
            }

            if (bookNameCounter != bookName)
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {counter} books.");
            }
            else
            {
                Console.WriteLine($"You checked {counter} books and found it.");
            }
        }
    }
}
