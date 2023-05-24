using System;

namespace P01.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeProjection = Console.ReadLine();
            int rowsQuantity = int.Parse(Console.ReadLine());
            int columnsQuantity = int.Parse(Console.ReadLine());

            double chairs = rowsQuantity * columnsQuantity;
            double price = 0;

            if (typeProjection == "Premiere")
            {
                price = chairs * 12;
            }
            else if (typeProjection == "Normal")
            {
                price = chairs * 7.5;
            }
            else
            {
                price = chairs * 5;
            }
            Console.WriteLine("{0:f2} leva", price);
        }
    }
}
