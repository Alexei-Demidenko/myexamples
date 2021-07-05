using System;

namespace Head_17_Extentions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AreaFigure areaFigure = new();
            int value = 5;

            Console.WriteLine($"Площадь квадрата = {areaFigure.Square(value)}");
            Console.WriteLine($"Площадь круга = {areaFigure.Circle(value)}");
            Console.WriteLine($"Площадь прямоугольного треугольника = {areaFigure.RightTriangle(value, value)}");
        }
    }
}
