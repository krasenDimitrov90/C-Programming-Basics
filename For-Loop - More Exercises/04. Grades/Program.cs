using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfStudents = int.Parse(Console.ReadLine());
            

            int countExelentStudents = 0;
            int countVeryGoodStudents = 0;
            int countGoodStudents = 0;
            int countFailStudents = 0;
            double averageGradeForAll = 0;
            for (int i = 1; i <= countOfStudents; i++)
            {
                double gradeOfOneStudent = double.Parse(Console.ReadLine());
                averageGradeForAll += gradeOfOneStudent;
                if (gradeOfOneStudent < 3 )
                {
                    countFailStudents++;

                }
                else if (gradeOfOneStudent < 4)
                {
                    countGoodStudents++;
                }
                else if (gradeOfOneStudent <5)
                {
                    countVeryGoodStudents++;
                }
                else
                {
                    countExelentStudents++;
                }
            }

            Console.WriteLine($"Top students: {(1.0 * countExelentStudents / countOfStudents)*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {(1.0 * countVeryGoodStudents / countOfStudents)*100:f2}% ");
            Console.WriteLine($"Between 3.00 and 3.99: {(1.0 * countGoodStudents / countOfStudents)*100:f2}%");
            Console.WriteLine($"Fail: {(1.0 * countFailStudents / countOfStudents)*100:f2}%");
            Console.WriteLine($"Average: {(1.0 * averageGradeForAll / countOfStudents):f2}");
        }
    }
}
