using System;

namespace _04.Steps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sumAllSteps = 0;
            bool isFinish = false;
            const int stepsThreshold = 10000;
            while (!isFinish && sumAllSteps < stepsThreshold)
            {
                string input = Console.ReadLine();
                int currentSteps;
                if (input == "Going home")
                {
                    currentSteps= int.Parse(Console.ReadLine());
                    isFinish = true;
                }
                else
                {
                    currentSteps = int.Parse(input);
                }
                sumAllSteps += currentSteps;
            }
            if (sumAllSteps >= stepsThreshold)
            {
                Console.WriteLine($"Goal reached! Good job!"); Console.WriteLine($"{sumAllSteps - stepsThreshold} steps over the goal!");
            }
            else
            {
                Console.WriteLine($"{stepsThreshold - sumAllSteps} more steps to reach goal.");
            }
        }
    }
}
