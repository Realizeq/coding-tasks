using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите год рождения: ");
        int birthYear = int.Parse(Console.ReadLine());

        Console.Write("Введите месяц рождения (1-12): ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.Write("Введите текущий год: ");
        int currentYear = int.Parse(Console.ReadLine());

        Console.Write("Введите текущий месяц (1-12): ");
        int currentMonth = int.Parse(Console.ReadLine());

        int age = currentYear - birthYear;

        if (currentMonth < birthMonth)
        {
            age = age - 1;
        }

        Console.WriteLine($"Возраст: {age} полных лет");
    }
}