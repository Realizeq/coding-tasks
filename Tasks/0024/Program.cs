using System;
class program
{
    static void Main()
    {
        Console.Write("Введите длину ребра куба: ");
        float a = Convert.ToSingle(Console.ReadLine());

        float v = a * a * a; // Вычисление объема куба
        float l_area = 4 * a * a; // Вычисление площади боковой поверхности куба

        Console.WriteLine($"\nПри длине ребра куба: {a}");
        Console.WriteLine($"Объем куба равен: {v}");
        Console.WriteLine($"Площадь боковой поверхности равна: {l_area}");
    }
}