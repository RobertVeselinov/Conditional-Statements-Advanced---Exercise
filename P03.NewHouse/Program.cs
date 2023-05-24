using System;
using System.ComponentModel.DataAnnotations;

namespace P03.NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int quantityFlowers = int.Parse(Console.ReadLine());
            int money = int.Parse(Console.ReadLine());

            double price = 0;

            if (flowerType == "Roses")
            {
                if (quantityFlowers <= 80)
                {
                    price = quantityFlowers * 5;
                }
                else
                {
                    price = quantityFlowers * 5;
                    price -= price * 0.1;
                }
            }
            else if (flowerType == "Dahlias")
            {
                if (quantityFlowers <= 90)
                {
                    price = quantityFlowers * 3.80;
                }
                else
                {
                    price = quantityFlowers * 3.80;
                    price -= price * 0.15;
                }
            }
            else if (flowerType == "Tulips")
            {
                if (quantityFlowers <= 80)
                {
                    price = quantityFlowers * 2.80;
                }
                else
                {
                    price = quantityFlowers * 2.80;
                    price -= price * 0.15;
                }
            }
            else if (flowerType == "Narcissus")
            {
                if (quantityFlowers < 120)
                {
                    price = quantityFlowers * 3;
                    price += price * 0.15;
                }
                else
                {
                    price = quantityFlowers * 3;
                }
            }
            else if (flowerType == "Gladiolus")
            {
                if (quantityFlowers < 80)
                {
                    price = quantityFlowers * 2.5;
                    price += price * 0.2;
                }
                else
                {
                    price = quantityFlowers * 2.5;
                }
            }
            if (money >= price)
            {
                Console.WriteLine($"Hey, you have a great garden with {quantityFlowers} {flowerType} and {Math.Abs(money - price):f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {Math.Abs(price - money):f2} leva more.");
            }
        }
    }
}
