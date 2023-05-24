using System;

namespace P04.FishingBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int quantityFisherMans = int.Parse(Console.ReadLine());

            double feeForShip = 0;

            if (season == "Spring")
            {
                feeForShip = 3000;
                if (quantityFisherMans <= 6)
                {
                    feeForShip -= feeForShip * 0.1;
                }
                else if (quantityFisherMans >= 7 && quantityFisherMans <= 11)
                {
                    feeForShip -= feeForShip * 0.15;
                }
                else if (quantityFisherMans >= 12)
                {
                    feeForShip -= feeForShip * 0.25;
                }

            }
            else if (season == "Summer" || season == "Autumn")
            {
                feeForShip = 4200;
                if (quantityFisherMans <= 6)
                {
                    feeForShip -= feeForShip * 0.1;
                }
                else if (quantityFisherMans >= 7 && quantityFisherMans <= 11)
                {
                    feeForShip -= feeForShip * 0.15;
                }
                else if (quantityFisherMans >= 12)
                {
                    feeForShip -= feeForShip * 0.25;
                }
            }
            else if (season == "Winter")
            {
                feeForShip = 2600;
                if (quantityFisherMans <= 6)
                {
                    feeForShip -= feeForShip * 0.1;
                }
                else if (quantityFisherMans >= 7 && quantityFisherMans <= 11)
                {
                    feeForShip -= feeForShip * 0.15;
                }
                else if (quantityFisherMans >= 12)
                {
                    feeForShip -= feeForShip * 0.25;
                }
            }
            if (season != "Autumn" && quantityFisherMans % 2 == 0)
            {
                feeForShip -= feeForShip * 0.05;
            }

            if (money >= feeForShip)
            {
                Console.WriteLine($"Yes! You have {Math.Abs(money - feeForShip):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {Math.Abs(feeForShip - money):f2} leva.");
            }
        }
    }
}
