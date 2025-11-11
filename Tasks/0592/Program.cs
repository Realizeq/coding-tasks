using System;
class Program
{
    static void Main()
    {
        double max_speed = 0;
        int max_index = 0;

        for (int j = 1; j <= 25; j++)
        {
            Console.Write($"автомобиль {j} - расстояние км: ");
            double distance = double.Parse(Console.ReadLine());

            Console.Write($"автомобиль {j} - время часы: ");
            double time = double.Parse(Console.ReadLine());

            double speed = distance / time;

            if (speed > max_speed)
            {
                max_speed = speed;
                max_index = j;
            }
        }

        Console.WriteLine($"автомобиль с максимальной скоростью: {max_index}");
    }
}