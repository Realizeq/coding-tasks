using System;
class Program
{
    static void TriangleInfo(double a, double b, double c, out double perimeter, out double area)
    {
        perimeter = a + b + c;
        double p = perimeter / 2;
        area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
    }

    static void Main()
    {
        Console.Write("Введите стороны первого треугольника (a b c): ");
        string[] sides1 = Console.ReadLine().Split(' ');
        double a1 = double.Parse(sides1[0]);
        double b1 = double.Parse(sides1[1]);
        double c1 = double.Parse(sides1[2]);

        Console.Write("Введите стороны второго треугольника (a b c): ");
        string[] sides2 = Console.ReadLine().Split(' ');
        double a2 = double.Parse(sides2[0]);
        double b2 = double.Parse(sides2[1]);
        double c2 = double.Parse(sides2[2]);

        double per1, area1;
        double per2, area2;

        TriangleInfo(a1, b1, c1, out per1, out area1);
        TriangleInfo(a2, b2, c2, out per2, out area2);

        double sumPer = per1 + per2;
        double sumArea = area1 + area2;

        Console.WriteLine($"\nПервый треугольник: периметр = {per1:F2}, площадь = {area1:F2}");
        Console.WriteLine($"Второй треугольник: периметр = {per2:F2}, площадь = {area2:F2}");
        Console.WriteLine($"Сумма периметров: {sumPer:F2}");
        Console.WriteLine($"Сумма площадей: {sumArea:F2}");
    }
}