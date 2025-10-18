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
        Console.Write("День: ");
        int birthDay = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите сегодняшнюю дату:");
        Console.Write("Год: ");
        int currentYear = int.Parse(Console.ReadLine());
        Console.Write("Месяц: ");
        int currentMonth = int.Parse(Console.ReadLine());
        Console.Write("День: ");
        int currentDay = int.Parse(Console.ReadLine());

        int age = currentYear - birthYear;

        if (currentMonth < birthMonth)
        {
            age = age - 1;
        }
        else if (currentMonth == birthMonth && currentDay < birthDay)
        {
            age = age - 1;
        }

        Console.WriteLine($"Возраст: {age} полных лет");
    }
}