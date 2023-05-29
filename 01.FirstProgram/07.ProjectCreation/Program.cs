using System;

namespace _07.ProjectCreation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int countOfProjects = int.Parse(Console.ReadLine());
            int result = countOfProjects * 3;
            Console.WriteLine($"The architect {name} will need {result} hours to complete {countOfProjects} project/s.");
        }
    }
}
