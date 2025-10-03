using System;
class program
{
    static void Main()
    {
        Console.WriteLine("Введите длину a: ");
        float a = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите ширину b: ");
        float b = Convert.ToSingle(Console.ReadLine());

        Console.WriteLine("Введите высоту c: ");
        float c = Convert.ToSingle(Console.ReadLine());

        float V = a * b * c;
        float litArea = 2 * (a * c + b * c);

        Console.WriteLine($"Объём: {V}");
        Console.WriteLine($"Площадь боковой поверхности: {litArea}");
    }
}