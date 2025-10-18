using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Введите дату рождения:");
        Console.Write("Год: ");
        int birthYear = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите сегодняшнюю дату:");
        Console.Write("Год: ");
        int currentYear = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int currentMonth = int.Parse(Console.ReadLine());

        int totalMonths = (currentYear - birthYear) * 12 + (currentMonth - birthMonth);

        int years = totalMonths / 12;
        int months = totalMonths % 12;

        if (months < 0)
        {
            years = years - 1;
            months = months + 12;
        }

        Console.WriteLine($"Возраст - {years} лет {months} месяцев");
    }
}