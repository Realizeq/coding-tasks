using System;
class program
{
    static void Main()
    {
        Console.Write("Введите радиус окружности: ");
        float r = Convert.ToSingle(Console.ReadLine());

        float pi = 3.14159f; // Число Пи
        float L = 2 * pi * r; // Вычисление длины окружности
        float S = pi * r * r; // Вычисление площади круга

        Console.WriteLine($"\nПри радиусе окружности: {r}");
        Console.WriteLine($"Длина окружности равна: {L:F2}");
        Console.WriteLine($"Площадь круга равна: {S:F2}");
    }
}