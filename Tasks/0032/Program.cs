using System;
class program
{
    static void Main()
    {
        // Ввод радиусов
        Console.Write("Введите внешний радиус (R): ");
        float R = Convert.ToSingle(Console.ReadLine());
        Console.Write("Введите внутренний радиус (r): ");
        float r = Convert.ToSingle(Console.ReadLine());

        // Вычисление площади кольца
        float pi = 3.14159f;
        float S = pi * (R * R - r * r);

        // Вывод площади кольца
        Console.WriteLine($"Площадь кольца равна {S:f2}");
    }
}