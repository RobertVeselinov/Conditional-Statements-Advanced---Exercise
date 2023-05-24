using System;

namespace P07.HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int quantityNights = int.Parse(Console.ReadLine());

            double apartmentPrice = 0;
            double studioPrice = 0;

            if (month == "May" || month == "October")
            {
                if (quantityNights <= 7)
                {
                    apartmentPrice = quantityNights * 65;
                    studioPrice = quantityNights * 50;
                }
                else if (quantityNights > 7 && quantityNights <=14)
                {
                    apartmentPrice = quantityNights * 65;
                    studioPrice = quantityNights * 50;
                    studioPrice -= studioPrice * 0.05;
                }
                else if (quantityNights > 14)
                {
                    studioPrice = quantityNights * 50;
                    studioPrice -= studioPrice * 0.3;
                    apartmentPrice = quantityNights * 65;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "June" || month == "September")
            {
                if (quantityNights <= 14 )
                {
                    apartmentPrice = quantityNights * 68.70;
                    studioPrice = quantityNights * 75.20;
                }
                else if (quantityNights > 14)
                {
                    studioPrice = quantityNights * 75.20;
                    studioPrice -= studioPrice * 0.2;
                    apartmentPrice = quantityNights * 68.70;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            else if (month == "July" || month == "August")
            {
                if (quantityNights <= 14)
                {
                    studioPrice = quantityNights * 76;
                    apartmentPrice = quantityNights * 77;
                }
                else if (quantityNights > 14)
                {
                    studioPrice = quantityNights * 76;
                    apartmentPrice = quantityNights * 77;
                    apartmentPrice -= apartmentPrice * 0.1;
                }
            }
            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }
    }
}
