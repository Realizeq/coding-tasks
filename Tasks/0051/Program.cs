using System;
class program
{
    static void Main()
    {
        Console.Write("Введите скорость первого автомобиля: ");
        float v1 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите скорость второго автомобиля: ");
        float v2 = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите расстояние между автомобилями: ");
        float s = Convert.ToSingle(Console.ReadLine());

        float totalSpeed = v1 + v2;
        float time = s / totalSpeed;

        Console.WriteLine($"Автомобили встретятся через {time:F2} часа");
    }
}