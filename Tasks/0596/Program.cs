using System;
class Program
{
    static void Main()
    {
        double min_time = double.MaxValue;
        double max_time = 0;
        int min_index = 0;
        int max_index = 0;

        Console.Write("количество этапов: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"этап {j}: ");
            double time = double.Parse(Console.ReadLine());

            if (time < min_time)
            {
                min_time = time;
                min_index = j;
            }

            if (time > max_time)
            {
                max_time = time;
                max_index = j;
            }
        }

        if (min_index < max_index) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}