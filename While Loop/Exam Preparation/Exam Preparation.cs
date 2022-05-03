using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Preparation
{
    class Program
    {
        static void Main(string[] args)
        {
            // НЕ Е РЕШЕНА ДОКРАЙ 90/100 ТОЧКИ

            int badGrades = int.Parse(Console.ReadLine()); // count of poorly grades

            string taskName = "";// name of the task
            int counter = 0; // total amaunt of tasks
            int sumGrades = 0;// sum of all grades
            int sumBadGrades = 0; // total amaunt of bad grades
            int grade = 0;
            string lastTask = "";

            while (taskName != "Enough")
            {
                
                taskName = Console.ReadLine(); // name of the task
                if (taskName != "Enough")
                {
                    grade = int.Parse(Console.ReadLine()); // grade for the task
                    counter++;
                    sumGrades += grade;
                    lastTask = taskName;
                }
                if (grade <= 4)
                {
                    sumBadGrades++;
                }
                if (sumBadGrades == badGrades)
                {
                    break;
                }

            }

            
            if (sumBadGrades == badGrades)
            {
                Console.WriteLine($"You need a break, {sumBadGrades} poor grades.");
            }
            else
            {
                double averageGrade = 1.0 * sumGrades / counter;
                Console.WriteLine($"Average score: {averageGrade:f2}");
                Console.WriteLine($"Number of problems: {counter}");
                Console.WriteLine($"Last problem: {lastTask}");
            }

            

        }
    }
}
