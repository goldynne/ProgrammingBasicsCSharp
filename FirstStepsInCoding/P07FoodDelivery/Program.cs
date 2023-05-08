using System;
namespace P07FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Ресторант отваря врати и предлага няколко менюта на преференциални цени: 
            //⦁	Пилешко меню –  10.35 лв.
            //⦁	Меню с риба – 12.40 лв.
            //⦁	Вегетарианско меню  – 8.15 лв.
            //Напишете програма, която изчислява колко ще струва на група хора да си поръчат храна за вкъщи.
            //Групата ще си поръча и десерт, чиято цена е равна на 20 % от общата сметка(без доставката). 
            //Цената на доставка е 2.50 лв и се начислява най - накрая.
            //Вход
            //От конзолата се четат 3 реда:
            //⦁	Брой пилешки менюта – цяло число в интервала[0 … 99]
            //⦁	Брой менюта с риба – цяло число в интервала[0 … 99]
            //⦁	Брой вегетариански менюта – цяло число в интервала[0 … 99]
            //Изход
            //Да се отпечата на конзолата един ред:  "{цена на поръчката}"


            int chickenMenuNumber = int.Parse(Console.ReadLine());
            int fishMenuNumber = int.Parse(Console.ReadLine());
            int veganMenuNumber = int.Parse(Console.ReadLine());

            double chickenMenuPrice = 10.35;
            double fishMenuPrice = 12.4;
            double veganMenuPrice = 8.15;
            double overallChickenPrice = chickenMenuNumber * chickenMenuPrice;
            double overallFishPrice = fishMenuNumber * fishMenuPrice;
            double overallVeganPrice = veganMenuNumber * veganMenuPrice;
            double menusPrice = overallChickenPrice + overallFishPrice + overallVeganPrice;
            double priceDessert = menusPrice * 0.2;

            double finalPrice =menusPrice+priceDessert+2.5;
            Console.WriteLine(finalPrice);
        }
    }
}