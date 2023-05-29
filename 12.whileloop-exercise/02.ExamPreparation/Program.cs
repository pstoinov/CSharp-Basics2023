using System;
using System.Xml;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumberOfBadGrades = int.Parse(Console.ReadLine());
            int sumOfGrades = 0;
            int countOfProblems = 0;
            string lastProblemName = string.Empty;
            int coutOfBadGrades = 0;

            string problemName = Console.ReadLine();
            while (problemName != "Enough")
            {
                int grade = int.Parse(Console.ReadLine());
                if (grade <= 4)
                {
                    coutOfBadGrades++;
                    
                    if (coutOfBadGrades == maxNumberOfBadGrades)
                    {
                        break;
                    }
                }
                sumOfGrades += grade;
                countOfProblems++;
                lastProblemName = problemName;
                problemName = Console.ReadLine();
            }

            if (coutOfBadGrades == maxNumberOfBadGrades)
            {
                Console.WriteLine($"You need a break, {coutOfBadGrades} poor grades.");
            }
            else
            {
                Console.WriteLine($"Average score: {(double)sumOfGrades / countOfProblems:f2}");
                Console.WriteLine($"Number of problems: {countOfProblems}");
                Console.WriteLine($"Last problem: {lastProblemName}");
            }


        }
    }
}
