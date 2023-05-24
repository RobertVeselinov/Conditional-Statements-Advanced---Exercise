using System;

namespace P08.OnTimeForTheExam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMinute = int.Parse(Console.ReadLine());
            int arriveHour = int.Parse(Console.ReadLine());
            int arriveMinutes = int.Parse(Console.ReadLine());

            int examSumMinutes = examHour * 60 + examMinute; 
           
            int arriveSumMinutes = arriveHour * 60 + arriveMinutes; 
           
            int difference = Math.Abs(examSumMinutes - arriveSumMinutes);
            int differenceHour = difference / 60;
            int differenceMinutes = difference % 60;

            if (arriveSumMinutes > examSumMinutes)
            {
                if (differenceHour != 0)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine("{0}:{1:00} hours after the start", differenceHour, differenceMinutes);
                }
                else
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference} minutes after the start");
                }
            }
            else if (arriveSumMinutes >= examSumMinutes - 30)
            {
                if (examSumMinutes == arriveSumMinutes)
                {
                    Console.WriteLine("On time");
                }
                else if (differenceHour == 0)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine("{0} minutes before the start", differenceMinutes);
                }
            }
            else if (arriveSumMinutes < examSumMinutes - 30)
            {
                if (differenceHour != 0)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0}:{1:00} hours before the start", differenceHour, differenceMinutes);
                }
                else
                {
                    Console.WriteLine("Early");
                    Console.WriteLine("{0} minutes before the start", differenceMinutes);
                }
            }

        }
    }
}