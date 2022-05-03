using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Room
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string month = Console.ReadLine();
            int overnight = int.Parse(Console.ReadLine());

            double studioPrice = 0;
            double apartmentPrice = 0;
            double totalStudioPrice = 0;
            double totalApartmentPrice = 0;

            if (month == "May" || month == "October")
            {
                studioPrice = 50.00;
                apartmentPrice = 65.00;

                if (overnight <= 7)
                {
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;

                }
                else if (overnight <= 14)
                {
                    studioPrice -= studioPrice * 0.05;
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }
                else
                {
                    studioPrice -= studioPrice * 0.30;
                    apartmentPrice -= apartmentPrice * 0.10;
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }
            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 75.20;
                apartmentPrice = 68.70;

                if (overnight <= 14)
                {
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }
                else if (overnight > 14)
                {
                    studioPrice -= studioPrice * 0.20;
                    apartmentPrice -= apartmentPrice * 0.10;
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }
            }
            else
            {
                studioPrice = 76.00;
                apartmentPrice = 77.00;
                if (overnight <= 14)
                {
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }
                else if (overnight > 14)
                {
                    
                    apartmentPrice -= apartmentPrice * 0.10;
                    totalStudioPrice = studioPrice * overnight;
                    totalApartmentPrice = apartmentPrice * overnight;
                }


            }
            Console.WriteLine($"Apartment: {totalApartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {totalStudioPrice:f2} lv.");
        }
    }
}
