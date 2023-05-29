using System;

namespace _08.Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int gradeCount = 1;
            double allGrade = 0;
            int poor = 0;
            while (gradeCount <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                
                
                if (grade < 4)
                {

                    poor++;
                    if (poor == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {gradeCount} grade");
                        return;
                    }
                    continue;
                }
                gradeCount++;
                allGrade += grade;

            }
            double average = allGrade / 12;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");


        }
    }
}
