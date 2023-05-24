using System;

namespace P01._2.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());

            double places = rows * columns;
            double price = 0;

            switch (typeProjection)
            {
                case "Premiere":
                    price = places * 12;
                    break;
                case "Normal":
                    price = places * 7.50;
                    break;
                case "Discount":
                    price = places * 5;
                    break;
            }
            Console.WriteLine("{0:f2} leva", price);
        }
    }
}
