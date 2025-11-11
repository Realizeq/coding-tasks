using System;
class Program
{
    static void Main()
    {
        int max = 0;
        int second_max = 0;

        for (int j = 1; j <= 12; j++)
        {
            Console.Write($"автомобиль {j}: ");
            int speed = int.Parse(Console.ReadLine());

            if (speed > max)
            {
                second_max = max;
                max = speed;
            }
            else if (speed > second_max)
            {
                second_max = speed;
            }
        }

        Console.WriteLine($"скорость больше которой только максимальная: {second_max}");
    }
}