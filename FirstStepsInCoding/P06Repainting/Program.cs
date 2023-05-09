using System;
namespace P06Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Румен иска да пребоядиса хола и за целта е наел майстори.Напишете програма,
            //която изчислява разходите за
            //ремонта, предвид следните цени:

            //            ⦁	Предпазен найлон -1.50 лв.за кв. метър
            //⦁	Боя - 14.50 лв.за литър
            //⦁	Разредител за боя - 5.00 лв.за литър
            //За всеки случай, към необходимите материали, Румен иска да добави още 10 % от количеството боя и
            //2 кв.м.найлон,
            //разбира се и 0.40 лв.за торбички. Сумата, която се заплаща на майсторите за 1 час работа, е равна
            //на 30 %
            //от сбора на всички разходи за материали.
            //Вход
            //Входът се чете от конзолата и съдържа точно 4 реда:
  
            //⦁	Необходимо количество найлон(в кв.м.) - цяло число в интервала[1... 100]
            //⦁	Необходимо количество боя(в литри) - цяло число в интервала[1…100]
            //⦁	Количество разредител(в литри) -цяло число в интервала[1…30]
            //⦁	Часовете, за които майсторите ще свършат работата -цяло число в интервала[1…9]
            //Изход
            //Да се отпечата на конзолата един ред:
            //⦁	"{сумата на всички разходи}"

            

            int necessaryNylonSqM = int.Parse(Console.ReadLine());   
            int paintLitres = int.Parse(Console.ReadLine());   
            int paintThinnerL = int.Parse(Console.ReadLine());   
            int craftsmenHours = int.Parse(Console.ReadLine());
           
            double nylonPricePerSqMeter = 1.5;
            double nylonOverallPrice = (necessaryNylonSqM +2)* nylonPricePerSqMeter;

            

            double paintThinnerPricePerL = 5;
            double paintThinnerOverallPrice = paintThinnerL * paintThinnerPricePerL;
            

            

            double paintPricePerLitre = 14.5;
            double paintOverallPrice = (paintLitres * paintPricePerLitre);
            double finalPaintPrice = paintOverallPrice * 0.1 +paintOverallPrice;

            
            double bagPrice = 0.4;

            double overallExpencesMaterials = nylonOverallPrice+paintThinnerOverallPrice+finalPaintPrice+bagPrice;
            double craftsmanWagePerHour = overallExpencesMaterials * 0.3;
            double craftsmenOverallSalary = craftsmanWagePerHour * craftsmenHours;

            double finalPrice = overallExpencesMaterials + craftsmenOverallSalary;

            Console.WriteLine(finalPrice);

        }
    }
}