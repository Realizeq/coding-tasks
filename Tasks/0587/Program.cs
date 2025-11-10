using System;
class Program
{
    static void Main()
    {
        double best_time = double.MaxValue;
        int best_start = 0;

        Console.Write("количество участников: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"участник {j}: ");
            double time = double.Parse(Console.ReadLine());

            if (time < best_time)
            {
                best_time = time;
                best_start = j;
            }
        }

        Console.WriteLine($"лучший результат у участника № {best_start}");
    }
}