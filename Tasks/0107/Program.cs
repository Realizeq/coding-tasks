using System;
class Program
{
    static void Main()
    {
        int h, m;

        Console.Write("Введите часы (от 1 до 12): ");
        h = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты (от 0 до 59): ");
        m = int.Parse(Console.ReadLine());

        float hourAngle = h * 30 + m * 0.5f;
        float minuteAngle = m * 6;

        float diff = Math.Abs(hourAngle - minuteAngle);
        if (diff > 180)
        {
            diff = 360 - diff;
        }

        float minutesToMatch = diff / 5.5f;

        float diff90 = Math.Abs(diff - 90);
        if (diff90 > 180)
        {
            diff90 = 360 - diff90;
        }

        float minutesToPerpendicular = diff90 / 5.5f;

        Console.WriteLine($"а) Минут до совпадения стрелок: {minutesToMatch:f2}");
        Console.WriteLine($"б) Минут до перпендикулярного положения: {minutesToPerpendicular:f2}");
    }
}