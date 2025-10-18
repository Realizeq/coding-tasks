using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите площадь круга: ");
        float circleArea = float.Parse(Console.ReadLine());

        Console.Write("Введите площадь квадрата: ");
        float squareArea = float.Parse(Console.ReadLine());

        float circleRadius = (float)Math.Sqrt(circleArea / Math.PI);
        float squareSide = (float)Math.Sqrt(squareArea);

        bool circleInSquare = (2 * circleRadius) <= squareSide;
        bool squareInCircle = (squareSide * (float)Math.Sqrt(2)) <= (2 * circleRadius);

        Console.WriteLine($"а) Уместится ли круг в квадрате - {circleInSquare}");
        Console.WriteLine($"б) Уместится ли квадрат в круге - {squareInCircle}");
    }
}