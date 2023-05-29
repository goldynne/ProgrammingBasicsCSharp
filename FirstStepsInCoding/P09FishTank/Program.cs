﻿using System;
namespace P09FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //За рождения си ден Любомир получил аквариум с формата на паралелепипед.Първоначално прочитаме от
            // конзолата на отделни редове размерите му – дължина, широчина и височина в сантиметри.Трябва да
            // се пресметне колко литра вода ще събира аквариума, ако се знае, че определен процент от
            // вместимостта му е заета от пясък, растения, нагревател и помпа.
            //Един литър вода се равнява на един кубичен дециметър / 1л = 1 дм3 /.
            //Да се напише програма, която изчислява литрите вода, която са необходими за напълването на
            //аквариума.
            //Вход
            //От конзолата се четат 4 реда:
            //⦁	Дължина в см – цяло число в интервала[10 … 500]
            //⦁	Широчина в см – цяло число в интервала[10 … 300]
            //⦁	Височина в см – цяло число в интервала[10… 200]
            //⦁	Процент  – реално число в интервала[0.000 … 100.000]
            //Изход
            //Да се отпечата на конзолата едно число:
            //⦁	литрите вода, които ще събира аквариума.


            int length = int.Parse(Console.ReadLine());   
            int width = int.Parse(Console.ReadLine());   
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());
            double convertedPercent = percent / 100;

            double volumeCubicCm = (length * width * height)*1.0;
            double volumeWithoutAdditionalThings = (volumeCubicCm)-(volumeCubicCm*convertedPercent);
            double volumeWater = volumeWithoutAdditionalThings / 1000;

            Console.WriteLine(volumeWater);
        }
    }
}