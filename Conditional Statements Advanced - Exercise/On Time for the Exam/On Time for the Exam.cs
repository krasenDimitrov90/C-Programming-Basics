using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace On_Time_for_the_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examhour = int.Parse(Console.ReadLine());  //2 часа
            int exammin = int.Parse(Console.ReadLine());  // 50 минути
            int arrivalhour = int.Parse(Console.ReadLine());
            int arrivalmin = int.Parse(Console.ReadLine());

            examhour = examhour * 60;//преобразуване часовете на изпита в минути
            int totalExamMin = examhour + exammin;//общ брой мин за часа на изпита

            arrivalhour = arrivalhour * 60;//преобразуване часовете на пристигане в минути
            int totalArrMin = arrivalhour + arrivalmin;//общ брой мин за часа на пристигане

            int timeDifference = 0;//разликата м/у времето на пристигане и часа на изпита
            int hour = 0;// разликата м/у часа на изпита и часа на пристигане
            int min = 0;// разликата м/у минутите на изпита и минутите на пристигане
            

            if (totalExamMin - totalArrMin > 30)
            {
                timeDifference = totalExamMin - totalArrMin;
                hour = timeDifference / 60;
                min = timeDifference % 60;

                if (timeDifference < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{min} minutes before the start");
                }
                else
                {
                    if (min < 10)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hour}:0{min} hours before the start");
                    }
                    else
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine($"{hour}:{min} hours before the start");
                    }
                }
            }
            else if (totalExamMin - totalArrMin <= 30  && totalExamMin - totalArrMin > -1)
            {
                timeDifference = totalExamMin - totalArrMin;
                hour = timeDifference / 60;
                min = timeDifference % 60;

                if (totalExamMin - totalArrMin == 0)
                {
                    Console.WriteLine("On time");
                }
                else
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{min} minutes before the start");
                }
            }
            else if (totalArrMin > totalExamMin)
            {
                timeDifference = totalArrMin - totalExamMin;
                hour = timeDifference / 60;
                min = timeDifference % 60;

                if (timeDifference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{min} minutes after  the start");
                }
                else
                {
                    if (min < 10)
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hour}:0{min} hours after  the start");
                    }
                    else
                    {
                        Console.WriteLine("Late");
                        Console.WriteLine($"{hour}:{min} hours after  the start");
                    }
                }
            }

        }
    }
}
