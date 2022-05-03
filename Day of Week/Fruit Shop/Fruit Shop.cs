using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            //banana	apple	orange	grapefruit	kiwi	pineapple	grapes
            //2.50	    1.20	0.85	1.45	    2.70	5.50	     3.85
            // 1.Find witch day of the week is  
            double price = 0;
            if ((day != "Monday" && day != "Tuesday" && day != "Wednesday" && day != "Thursday" &&
                day != "Friday" && day != "Saturday" && day != "Sunday") ||
                (fruit != "banana" && fruit != "apple" && fruit != "orange" && fruit != "grapefruit" &&
                fruit != "kiwi" && fruit != "pineapple" && fruit != "grapes"))
            {
                Console.WriteLine("error");
            }

            else 

            {
                switch (day)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                        if (fruit == "banana")
                        {
                            price = quantity * 2.50;
                        }
                        else if (fruit == "apple")
                        {
                            price = quantity * 1.20;
                        }
                        else if (fruit == "orange")
                        {
                            price = quantity * 0.85;
                        }
                        else if (fruit == "grapefruit")
                        {
                            price = quantity * 1.45;
                        }
                        else if (fruit == "kiwi")
                        {
                            price = quantity * 2.70;
                        }
                        else if (fruit == "pineapple")
                        {
                            price = quantity * 5.50;
                        }
                        else if (fruit == "grapes")
                        {
                            price = quantity * 3.85;
                        }
                        break;

                    case "Saturday":
                    case "Sunday":

                        //banana	apple	orange	grapefruit	kiwi	pineapple	grapes
                        //2.70	    1.25	0.90	1.60	    3.00	5.60	    4.20
                        if (fruit == "banana")
                        {
                            price = quantity * 2.70;
                        }
                        else if (fruit == "apple")
                        {
                            price = quantity * 1.25;
                        }
                        else if (fruit == "orange")
                        {
                            price = quantity * 0.90;
                        }
                        else if (fruit == "grapefruit")
                        {
                            price = quantity * 1.60;
                        }
                        else if (fruit == "kiwi")
                        {
                            price = quantity * 3.00;
                        }
                        else if (fruit == "pineapple")
                        {
                            price = quantity * 5.60;
                        }
                        else if (fruit == "grapes")
                        {
                            price = quantity * 4.20;
                        }
                        break;

                }
                Console.WriteLine($"{price:f2}");
            } 
        }
    }
}
