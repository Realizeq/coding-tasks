using System;
class Program
{
    static void Main()
    {
        int h, m, s;

        Console.Write("Введите часы (0 < h <= 23): ");
        h = int.Parse(Console.ReadLine());

        Console.Write("Введите минуты (0 <= m <= 59): ");
        m = int.Parse(Console.ReadLine());

        Console.Write("Введите секунды (0 <= s <= 59): ");
        s = int.Parse(Console.ReadLine());

        double totalHours = h + m / 60.0 + s / 3600.0;
        double angle = totalHours * 30;

        Console.WriteLine($"Угол часовой стрелки: {angle}°");
    }
}