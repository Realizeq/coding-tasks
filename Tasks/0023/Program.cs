using System;
class program
{
    static void Main()
    {
        float R = 6350f; // Радиус Земли в километрах

        Console.Write("Введите высоту наблюдения (км): ");
        float h = Convert.ToSingle(Console.ReadLine()); // Высота наблюдения в километрах

        // Вычисление расстояния до горизонта
        float sqrt_h = h * (2 * R + h);
        float L = MathF.Sqrt(sqrt_h);

        Console.WriteLine($"Расстояние до горизонта {L:F2} км");
    }
}