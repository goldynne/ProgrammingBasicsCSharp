using System;
namespace P08LunchBreak
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            По време на обедната почивка искате да изгледате епизод от своя любим сериал.Вашата
            //            задача е да напишете програма, с която ще разберете дали имате достатъчно време да
            //            изгледате епизода. По време на почивката отделяте време за обяд и време за отдих.
            //            Времето за обяд ще бъде 1 / 8 от времето за почивка, а времето за отдих ще бъде
            //            1 / 4 от времето за почивка. 
            //Вход
            //От конзолата се четат 3 реда:
            //⦁	Име на сериал – текст
            //⦁	Продължителност на епизод  – цяло число в диапазона[10… 90]
            //⦁	Продължителност на почивката  – цяло число в диапазона[10… 120]
            //Изход
            //На конзолата да се изпише един ред:
            //⦁	Ако времето е достатъчно да изгледате епизода:
            //            "You have enough time to watch {име на сериал} and left with {останало време} minutes free time."
            //⦁	Ако времето не Ви е достатъчно:
            //"You don't have enough time to watch {име на сериал}, you need {нужно време} more minutes."
            //Времето да се закръгли до най-близкото цяло число нагоре.


            string seriesName = Console.ReadLine();

            int seriesDuration = int.Parse(Console.ReadLine());

            int minutesBreak = int.Parse(Console.ReadLine());
            double minutesLunch = minutesBreak / 8.0;
            double minutesRecreation = minutesBreak / 4.0;
            double timeForSeries = minutesBreak - minutesRecreation-minutesLunch;
            if (timeForSeries>=seriesDuration)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(timeForSeries-seriesDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesDuration-timeForSeries)} more minutes.");
            }

        }
    }
}