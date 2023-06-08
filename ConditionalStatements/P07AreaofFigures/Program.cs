using System;
namespace P07AreaofFigures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, в която потребителят въвежда вида и 
            //                размерите на геометрична фигура и пресмята лицето й.Фигурите
            //                са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и 
            //                триъгълник(triangle). На първия ред на входа се чете вида на фигурата(текст със 
            //                    следните възможности: square, rectangle, circle или triangle). 
            //⦁	Ако фигурата е квадрат(square): на следващия ред се чете едно дробн
            //                о число -дължина на страната му
            //⦁	Ако фигурата е правоъгълник(rectangle): на следващите два реда чета
            //                т две дробни числа -дължините на страните му
            //⦁	Ако фигурата е кръг(circle): на следващия ред чете едно дробно числ
            //                о - радиусът на кръга
            //⦁	Ако фигурата е триъгълник(triangle): на следващите два реда четат д
            //                ве дробни числа -дължината на страната му и дължината на височината към нея
            //Резултатът да се закръгли до 3 цифри след десетичната запетая. 


            string figureType = Console.ReadLine();
            double area = 0;
            if (figureType == "square")
            {

                double a = double.Parse(Console.ReadLine());

                 area = a*a;
            }
                        else if (figureType == "rectangle")
            {

                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                 area = a * b;
            }
            else if(figureType == "circle")
            {

                double r = double.Parse(Console.ReadLine());
                 area = Math.PI*r*r;
            }
            else if (figureType == "triangle")
            {

                double a = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                 area = (a * h)/2;
            }
            area = Math.Round(area, 3);
            Console.WriteLine(area);

        }
    }
}