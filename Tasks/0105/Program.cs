using System;
class Program
{
    static void Main()
    {
        double y;

        Console.Write("Введите угол в градусах (0 < y < 360): ");
        y = double.Parse(Console.ReadLine());

        double totalHours = y / 30;
        int hours = (int)totalHours;
        int minutes = (int)((totalHours - hours) * 60);

        Console.WriteLine($"Прошло полных часов: {hours}");
        Console.WriteLine($"Прошло полных минут: {minutes}");
    }
}