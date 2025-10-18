using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите площадь круга: ");
        float circleArea = float.Parse(Console.ReadLine());

        Console.Write("Введите площадь треугольника: ");
        float triangleArea = float.Parse(Console.ReadLine());

        float circleRadius = (float)Math.Sqrt(circleArea / Math.PI);
        float triangleSide = (float)Math.Sqrt((4 * triangleArea) / (float)Math.Sqrt(3));

        float triangleInradius = triangleSide * (float)Math.Sqrt(3) / 6;
        float triangleCircumradius = triangleSide * (float)Math.Sqrt(3) / 3;

        bool circleInTriangle = circleRadius <= triangleInradius;
        bool triangleInCircle = triangleCircumradius <= circleRadius;

        Console.WriteLine($"а) Уместится ли круг в треугольнике - {circleInTriangle}");
        Console.WriteLine($"б) Уместится ли треугольник в круге - {triangleInCircle}");
    }
}