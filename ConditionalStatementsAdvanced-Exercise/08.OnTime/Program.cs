using System;

namespace _08.OnTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hourExam = int.Parse(Console.ReadLine());
            int minExam = int.Parse(Console.ReadLine());
            int hourArriving = int.Parse(Console.ReadLine());
            int minArriving = int.Parse(Console.ReadLine());
            int hourExamInMin = hourExam * 60;
            int allTimeExam = hourExamInMin + minExam;
            int hourArrivingInMin = hourArriving * 60;
            int allTimeArriving = hourArrivingInMin + minArriving;
            string output, keyword;
            if (allTimeArriving > allTimeExam)
            {
                output = "Late";
                keyword = "after";
            }
            else
            {
                if (allTimeArriving >= allTimeExam - 30)
                {
                    output = "On time";
                }
                else
                {
                    output = "Early";
                    
                }
                keyword = "before";
            }
            int diff = Math.Abs(allTimeArriving- allTimeExam);
            int diffHour = diff / 60;
            int diffMin = diff % 60;
            string formatedDiff;
            if ( diffHour == 0)
            {
                formatedDiff = $"{diffMin} minutes";
            }
            else
            {
                if (diffMin < 10)
                {
                    formatedDiff = $"{diffHour}:0{diffMin} hours";
                    
                }
                else formatedDiff = $"{diffHour}:{diffMin} hours";
            }
            if (diff == 0) Console.WriteLine(output);
            else
            {
                Console.WriteLine(output);
                Console.WriteLine($"{formatedDiff} {keyword} the start");
            }

        }

    }
}
