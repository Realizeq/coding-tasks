using System;
class Program
{
    static void Main()
    {
        int max = 0;

        for (int j = 1; j <= 20; j++)
        {
            Console.Write($"автомобиль {j}: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed > max) max = speed;
        }

        Console.WriteLine($"максимальная скорость: {max} км/ч");
    }
}