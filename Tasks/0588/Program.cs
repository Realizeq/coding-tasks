using System;
class Program
{
    static void Main()
    {
        int min_points = int.MaxValue;
        int min_team = 0;

        Console.Write("количество команд: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"команда {j}: ");
            int points = int.Parse(Console.ReadLine());

            if (points < min_points)
            {
                min_points = points;
                min_team = j;
            }
        }

        Console.WriteLine($"наименьшее количество очков у команды № {min_team}");
    }
}