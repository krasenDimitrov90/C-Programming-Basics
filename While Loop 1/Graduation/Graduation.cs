using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string scholarName = Console.ReadLine();
             
            int counterClasses = 0;// Count the grade of the scholar
            int badGrades = 0; // Counter for the bad grades
            double sumOfGrades = 0;// Sum of all grades

            while (counterClasses < 12)
            {
                double grade = double.Parse(Console.ReadLine());// Grade of the scholar
                sumOfGrades += grade;

                if (grade < 4)
                {
                    badGrades++;
                }
                if (badGrades == 2)
                {
                    break;
                }
                counterClasses++;
            }
            if (badGrades == 2)
            {
                Console.WriteLine($"{scholarName} has been excluded at {counterClasses} grade");
            }
            else
            {
                Console.WriteLine($"{scholarName} graduated. Average grade: {sumOfGrades / counterClasses:f2}");
            }
        }
    }
}
