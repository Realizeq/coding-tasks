using System;
class Program
{
    static void Main()
    {
        float radius, side;

        Console.Write("Введите радиус круга: ");
        radius = float.Parse(Console.ReadLine());

        Console.Write("Введите сторону квадрата: ");
        side = float.Parse(Console.ReadLine());

        float circleArea = (float)Math.PI * radius * radius;
        float squareArea = side * side;

        string result;

        if (circleArea > squareArea)
        {
            result = "круг";
        }
        else
        {
            result = "квадрат";
        }

        Console.WriteLine($"Большая площадь : {result}");
    }
}