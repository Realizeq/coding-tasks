using System;
class program
{
    static void Main()
    {
        Console.Write("Введите скорость первого автомобиля: ");
        float v1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите скорость второго автомобиля: ");
        float v2 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите начальное опережение: ");
        float s0 = Convert.ToSingle(Console.ReadLine());

        float totalSpeed = v1 - v2;
        float time = 0.5f;
        float dist = s0 + totalSpeed * time;

        Console.WriteLine($"Расстояние между автомобилями через 30 минут: {dist:F2} км");
    }
}