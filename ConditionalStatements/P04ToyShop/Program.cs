using System;
namespace P04ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Петя има магазин за детски играчки. Тя получава голяма поръчка, която трябва да
            //                изпълни.С парите, които ще спечели иска да отиде на екскурзия.

            //Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25 % от общата цена. От 
            //                спечелените пари Петя трябва да даде 10 % за наема на магазина.Да се пресметне 
            //                дали парите ще ѝ стигнат да отиде на екскурзия.
            //Вход
            //От конзолата се четат 6 реда:
            //⦁	Цена на екскурзията - реално число в интервала[1.00 … 10000.00]
            //⦁	Брой пъзели -цяло число в интервала[0… 1000]
            //⦁	Брой говорещи кукли - цяло число в интервала[0 … 1000]
            //⦁	Брой плюшени мечета - цяло число в интервала[0 … 1000]
            //⦁	Брой миньони -цяло число в интервала[0 … 1000]
            //⦁	Брой камиончета -цяло число в интервала[0 … 1000]
            //Цени на играчките:
            //⦁	Пъзел - 2.60 лв.
            //⦁	Говореща кукла -3 лв.
            //⦁	Плюшено мече -4.10 лв.
            //⦁	Миньон - 8.20 лв.
            //⦁	Камионче - 2 лв.
            //Изход
            //На конзолата се отпечатва:
            //⦁	Ако парите са достатъчни се отпечатва:
            //⦁	"Yes! {оставащите пари} lv left."
            //⦁	Ако парите НЕ са достатъчни се отпечатва:
            //⦁	"Not enough money! {недостигащите пари} lv needed."

            //Резултатът трябва да се форматира до втория знак след десетичната запетая.


            double tripPrice = double.Parse(Console.ReadLine());

            int puzzles = int.Parse(Console.ReadLine());
            int speakingDolls = int.Parse(Console.ReadLine());
            int teddybears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());
            


            double puzzlePrice = puzzles*2.6;
            double dollPrice = speakingDolls*3.0;
            double teddybearPrice = teddybears*4.1;
            double minionPrice = minions*8.2;
            double truckPrice = trucks*2.0;



            double income = puzzlePrice+dollPrice+teddybearPrice+minionPrice+truckPrice;
            double finalIncome = 0;
            int numberToys = puzzles+speakingDolls+teddybears+minions+trucks;
            if (numberToys >=50)
            {
                finalIncome = income - (income * 0.25);
            }
            else
            {
                finalIncome = income;
            }
            double moneyLeft = finalIncome-(finalIncome*0.1);

            if (moneyLeft>=tripPrice)
            {
                Console.WriteLine($"Yes! {(moneyLeft-tripPrice):F2} lv left.");
            }
            else
            {
                double neededMoney = tripPrice - moneyLeft;
                Console.WriteLine($"Not enough money! {neededMoney:F2} lv needed.");
            }
            
        }
    }
}