using System;
namespace P07Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Петър иска да купи N видеокарти, M процесора и P на брой рам памет.Ако броя на
            //            видеокартите е по-голям от този на процесорите получава 15 % отстъпка от крайната
            //            сметка.Важат следните цени:
            //⦁	Видеокарта – 250 лв./ бр.
            //⦁	Процесор – 35 % от цената на закупените видеокарти/ бр.
            //⦁	Рам памет – 10 % от цената на закупените видеокарти/ бр.
            //Да се изчисли нужната сума за закупуване на материалите и да се пресметне дали бюджета ще му стигне.
            //Вход
            //Входът се състои от четири реда:
            //⦁	Бюджетът на Петър - реално число в интервала[0.0…100000.0]
            //⦁	Броят видеокарти -цяло число в интервала[0…100]
            //⦁	Броят процесори -цяло число в интервала[0…100]
            //⦁	Броят рам памет - цяло число в интервала[0…100]
            //Изход
            //На конзолата се отпечатва 1 ред, който трябва да изглежда по следния начин:
            //⦁	Ако бюджета е достатъчен:
            //"You have {остатъчен бюджет} leva left!"
            //⦁	Ако сумата надхвърля бюджета:
            //"Not enough money! You need {нужна сума} leva more!"
            //Резултатът да се форматира до втория знак след десетичната запетая.


            double budget = double.Parse(Console.ReadLine());

            int videocards = int.Parse(Console.ReadLine());
            int proccessors = int.Parse(Console.ReadLine());
            int ram = int.Parse(Console.ReadLine());


            double videocardPrice = 250;
            double finalVideocardPrice = videocards * videocardPrice;

            double proccessorPrice = finalVideocardPrice * 0.35;
            double finalProccessorsPrice = proccessors * proccessorPrice;
            double ramPrice = finalVideocardPrice * 0.1;
            double finalRamPrice = ram * ramPrice;
            double finalPrice = finalVideocardPrice + finalProccessorsPrice + finalRamPrice;
            if (videocards>proccessors)
            {
                finalPrice = finalPrice*0.85;
            }

            if (budget-finalPrice >=0)
            {
                Console.WriteLine($"You have {budget-finalPrice:F02} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {finalPrice-budget:F02} leva more!");
            }

        }
    }
}