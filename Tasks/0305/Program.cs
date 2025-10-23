using System;
class Program
{
    static void Main()
    {
        float distance = 10.0f;
        float total = 0.0f;

        // а)
        Console.WriteLine("а) Пробег:");
        for (int day = 1; day <= 10; day++)
        {
            if (day >= 2)
            {
                Console.WriteLine($"{day} день - {distance:F2} км");
            }
            if (day <= 7)
            {
                total += distance;
            }
            distance *= 1.1f;
        }

        // б)
        Console.WriteLine($"б) Суммарный путь за первые 7 дней - {total:F2} км");
    }
}