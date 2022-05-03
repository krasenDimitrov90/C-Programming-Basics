using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wedding_Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            char sector = char.Parse(Console.ReadLine());// The last sector presented with a Letter
            int rows = int.Parse(Console.ReadLine());// Count of rows for the first sector
            int seats = int.Parse(Console.ReadLine());// Count for the odd seats in a row

            // For every next sector the rows increased with 1

            // The count of the seats on even rows are with 2 more from theese on the odd rows

            int sectorRowsCounter = 0; // For every next sector the rows increased with 1
            int totalSeatsCounter = 0;

            for (char i = 'A'; i <= sector; i++)
            {
                int oddEvenSeatsCounter = 0;
                for (int j = 1; j <= rows + sectorRowsCounter; j++)
                {
                    int evenOddSeats = 0;
                    oddEvenSeatsCounter++;
                    if (oddEvenSeatsCounter % 2 == 0)
                    {
                        evenOddSeats = seats + 2;
                    }
                    else
                    {
                        evenOddSeats = seats;
                    }

                    char seatLetter = 'a';
                    for (int k = 1; k <= evenOddSeats; k++)
                    {
                        Console.WriteLine($"{i}{j}{seatLetter}");
                        seatLetter++;
                        totalSeatsCounter++;
                    }
                    
                }
                sectorRowsCounter++;
            }
            Console.WriteLine(totalSeatsCounter);
        }
    }
}
