using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfJudges = int.Parse(Console.ReadLine());
            int totalCountOfGrade = 0, currentCountOfGrade = 0;
            double sumCurrentGrade = 0, sumTotalGrade = 0;
            bool isFinish = false;
            while (!isFinish)
            {
                string assigment = Console.ReadLine();
                if (assigment != "Finish")
                {

                    for (int i = 0; i < numOfJudges; i++)
                    {
                        double currentGrade = double.Parse(Console.ReadLine());
                        totalCountOfGrade++;
                        currentCountOfGrade++;
                        sumCurrentGrade += currentGrade;
                        sumTotalGrade += currentGrade; 
                    }

                    double averrageCurrentGrade = sumCurrentGrade / currentCountOfGrade;
                    Console.WriteLine($"{assigment} - {averrageCurrentGrade:F2}.");
                    currentCountOfGrade = 0;
                    sumCurrentGrade = 0;
                }
                else
                {
                    isFinish = true;
                }
            }
            double averrageTotalGrade = sumTotalGrade / totalCountOfGrade;
            Console.WriteLine($"Student's final assessment is {averrageTotalGrade:f2}.");
        }
    }
}
