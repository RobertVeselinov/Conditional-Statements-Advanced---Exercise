using System;

namespace P09.SkiTrip
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

            if ( typeRoom == "room for one person")
            {
                price = nights * 18.00;
            }
            else if (typeRoom == "apartment")
            {
                price = nights * 25;

                if (nights < 10)
                {
                    price -= price * 0.3;
                }
                else if (nights >= 10 && nights <= 15)
                {
                    price -= price * 0.35;
                }
                else
                {
                    price -= price * 0.5;
                }
            }
            else if (typeRoom == "president apartment")
            {
                price = nights * 35;

                if (nights < 10)
                {
                    price -= price * 0.1;
                }
                else if (nights >= 10 && nights <=15)
                {
                    price -= price * 0.15;
                }
                else
                {
                    price -= price * 0.2;
                }
            }

            if (rate == "positive")
            {
                price += price * 0.25; 
            }
            else
            {
                price -= price * 0.1;
            }

            Console.WriteLine($"{price:f2}");

        }
    }
}
