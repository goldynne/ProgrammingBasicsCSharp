using System;
namespace P01DayOfWeek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Напишете програма, която чете цяло число, въведено от потребителя, и
            //отпечатва ден от седмицата(на английски език), в граници[1...7] или
            //отпечатва "Error" в случай, че въведеното число е невалидно. 


            int number = int.Parse(Console.ReadLine());
            if (number == 1)
            {
                Console.WriteLine("Monday");
            }
            else if (number == 2)
            {
                Console.WriteLine("Tuesday");
            }
            else if (number ==3)
            {
                Console.WriteLine("Wednesday");
            }
            else if (number == 4)
            {
                Console.WriteLine("Thursday");
            }
            else if (number == 5)
            {
                Console.WriteLine("Friday");
            }
            else if (number == 6)
            {
                Console.WriteLine("Saturday");
            }
            else if (number == 7)
            {
                Console.WriteLine("Sunday");
            }
            else
            {
                Console.WriteLine("Error");
            }

        }
    }
}