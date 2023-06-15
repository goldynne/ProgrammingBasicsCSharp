using System;
namespace P02BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Дадено е цяло число – начален брой точки.Върху него се начисляват 
            //                бонус точки по правилата, описани по - долу.Да се напише програма, 
            //                която пресмята бонус точките, които получава числото и общия брой точки(числото
            //                +бонуса).
            //⦁	Ако числото е до 100 включително, бонус точките са 5.
            //⦁	Ако числото е по-голямо от 100, бонус точките са 20 % от числото.
            //⦁	Ако числото е по-голямо от 1000, бонус точките са 10 % от числото.

            //⦁	Допълнителни бонус точки(начисляват се отделно от предходните):
            //⦁	За четно число + 1 т.
            //⦁	За число, което завършва на 5 + 2 т.


            int number = int.Parse(Console.ReadLine());

            double bonus = 0;

            double additionalBonus = 0;
            if (number <= 100)
            {
                bonus = 5;

            }
            else if(number <= 1000)
            {
                bonus = number * 0.2;
            }else if (number >1000)
            {
                bonus = number * 0.1;
            }

            if (number %2 ==0)
            {
                additionalBonus = 1;
            }

            if (number % 10 == 5)
            {
                additionalBonus = 2;
            }

            double sumBonuses = bonus + additionalBonus;
            double sumNumberBonuses = number + bonus + additionalBonus;
            Console.WriteLine(sumBonuses);
            Console.WriteLine(sumNumberBonuses);
        }
    }
}