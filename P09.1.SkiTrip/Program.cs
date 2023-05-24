using System;

namespace P09._1.SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string typeRoom = Console.ReadLine();
            string rate = Console.ReadLine();

            int nights = days - 1;
            double price = 0;

            switch (typeRoom)
            {
                case "room for one person":
                    price = nights * 18;
                    break;
                case "apartment":
                    price = nights * 25;
                    break;
                case "president apartment":
                    price = nights * 35;
                    break;
            }

            if (typeRoom == "apartment")
            {
                if (nights < 10)
                {
                    price -= price * 0.3;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price -= price * 0.35;
                }
                else if (nights > 15)
                {
                    price -= price * 0.5;
                }
            }
            if (typeRoom == "president apartment")
            {
                if (nights < 10)
                {
                    price -= price * 0.1;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price -= price * 0.15;
                }
                else if (nights > 15)
                {
                    price -= price * 0.2;
                }
            }

            if (rate == "positive")
            {
                price += price * 0.25;
            }
            else if (rate == "negative")
            {
                price -= price * 0.1;
            }
            Console.WriteLine($"{price:f2}");
        }
    }
}