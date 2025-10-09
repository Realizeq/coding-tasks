using System;

class Program
{
    static void Main()
    {
        float y;

        Console.Write("Введите угол в радианах (0 < y < 2pi): ");
        y = float.Parse(Console.ReadLine());

        float totalHours = y * 6 / (float)Math.PI;
        int hours = (int)totalHours;
        int minutes = (int)((totalHours - hours) * 60);

        float minuteAngle = (hours * 60 + minutes) * 0.5f;

        Console.WriteLine($"Значение угла для минутной стрелки: {minuteAngle}°");
        Console.WriteLine($"Полных часов: {hours}");
        Console.WriteLine($"Полных минут: {minutes}");
    }
}