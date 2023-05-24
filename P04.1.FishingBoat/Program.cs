using System;

namespace P04._1.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int quantityFisherMans = int.Parse(Console.ReadLine());

            double priceForShip = 0;

            switch (season)
            {
                case "Spring":
                    priceForShip = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    priceForShip = 4200;
                    break;
                case "Winter":
                    priceForShip = 2600;
                    break;
            }
            if (quantityFisherMans <= 6)
            {
                priceForShip -= priceForShip * 0.1;
            }
            else if (quantityFisherMans >= 7 && quantityFisherMans <= 11)
            {
                priceForShip -= priceForShip * 0.15;
            }
            else
            {
                priceForShip -= priceForShip * 0.25;
            }

            if (season != "Autumn" && quantityFisherMans % 2 == 0)
            {
                priceForShip -= priceForShip * 0.05;
            }

            if (budget >= priceForShip)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(budget - priceForShip):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(priceForShip - budget):f2} leva.");
            }
        }
    }
}
