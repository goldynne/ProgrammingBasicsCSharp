using System;
namespace P03TimePlus15Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Да се напише програма, която чете час и минути от 24 - часово денонощие, 
            //    въведени от потребителя и изчислява колко ще е часът след 15 минути.Резултатът 
            //    да се отпечата във формат часове: минути.Часовете винаги са между 0 и 23, а минутите 
            //    винаги са между 0 и 59.Часовете се изписват с една или две цифри.Минутите се изписват 
            //    винаги с по две цифри, с водеща нула, когато е необходимо. 




            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int newMinutes = minutes + 15;
            if (newMinutes>59)
            {
                int newHours = hours+ 1;
                if (newHours>23)
                {
                    if (hours == 24)
                    {
                        hours = 0;
                    }
                    else
                    {
                        hours = newHours - 24;
                    }
                }else {
                    hours = newHours;

                }
                if (newMinutes == 60)
                {
                    minutes = 0;
                }
                else
                {
                    minutes = newMinutes - 60;
                }
            } else
            {
                minutes = newMinutes;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hours}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hours}:{minutes}");
            }
        }
    }
}