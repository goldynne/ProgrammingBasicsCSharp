using System;

namespace P08PetShop
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int dogFood = int.Parse(Console.ReadLine());
            int catFood = int.Parse(Console.ReadLine());

            double dogFoodPrice = 2.5;
            double catFoodPrice = 4;

            double overallDogFoodPrice = dogFood * dogFoodPrice;
            double overallCatFoodPrice = catFood*catFoodPrice;
            double overallPrice = overallDogFoodPrice + overallCatFoodPrice;
            Console.WriteLine($"{overallPrice} lv.");
        }
    }
}
