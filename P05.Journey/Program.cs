using System;

namespace P05.Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double spendMoney = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    spendMoney = budget * 0.3;
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.7;
                }
            }
            else if (budget <= 1000)
            {
                if ( season == "summer")
                {
                    spendMoney = budget * 0.4;
                }
                else if (season == "winter")
                {
                    spendMoney = budget * 0.8;
                }
            }
            else if (budget > 1000)
            {
                spendMoney = budget * 0.9;
            }

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {spendMoney:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {spendMoney:f2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {spendMoney:f2}");
                }
                else if (season == "winter")
                {
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {spendMoney:f2}");
                }
            }
            else if (budget > 1000)
            {
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {spendMoney:f2}");
            }
        }
    }
}
