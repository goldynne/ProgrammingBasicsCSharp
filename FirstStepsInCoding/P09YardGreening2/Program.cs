using System;

namespace P09YardGreening2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double yard = double.Parse(Console.ReadLine());
            double pricePerSquareMeter = 7.61;
            double price = pricePerSquareMeter * yard;
            double discount = price * 0.18;
            double PriceWithDiscount = price - discount;

            Console.WriteLine($"The final price is: {PriceWithDiscount} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");
        }
    }
}