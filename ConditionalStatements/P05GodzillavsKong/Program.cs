using System;
namespace P05GodzillavsKong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Снимките за дългоочаквания филм "Годзила срещу Конг" започват.Сценаристът Адам Уингард
            //            ви моли да напишете програма, която да изчисли, дали предвидените средства са достатъчни за
            //            снимането на филма. За снимките  ще бъдат нужни определен брой статисти, облекло за всеки
            //            един статист и декор.
            //Известно е, че:
            //⦁	Декорът за филма е на стойност 10 % от бюджета.
            //⦁	При повече от 150 статиста,  има отстъпка за облеклото на стойност 10 %.
            //Вход
            //От конзолата се четат 3 реда:
            //⦁	Бюджет за филма – реално число в интервала[1.00 … 1000000.00]
            //⦁	Брой на статистите – цяло число в интервала[1 … 500]
            //⦁	Цена за облекло на един статист – реално число в интервала[1.00 … 1000.00]
            //Изход
            //На конзолата трябва да се отпечатат два реда:
            //⦁	Ако парите за декора и дрехите са повече от бюджета:
            //⦁	"Not enough money!"
            //⦁	"Wingard needs {парите недостигащи за филма} leva more."
            //⦁	Ако парите за декора и дрехите са по малко или равни на бюджета:
            //⦁	"Action!"
            //⦁	"Wingard starts filming with {останалите пари} leva left."
            //Резултатът трябва да е форматиран до втория знак след десетичната запетая.

            double budget = double.Parse(Console.ReadLine());
            double priceDecor = budget * 0.1;
            int actors = int.Parse(Console.ReadLine());

            double priceClothingActor = double.Parse(Console.ReadLine());
            double overallPriceClothing = priceClothingActor * actors;
            
            if (actors > 150)
            {
                overallPriceClothing = overallPriceClothing* 0.9;
            }

            double priceClothingAndDecor = overallPriceClothing + priceDecor;
            if (priceClothingAndDecor>budget)
            {
                Console.WriteLine("Not enough money!");
                double moneyNeeded = priceClothingAndDecor - budget;
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            if (priceClothingAndDecor <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {budget-priceClothingAndDecor:F2} leva left.");
            }
            
          

        }
    }
}