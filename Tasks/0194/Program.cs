using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите возраст в месяцах: ");
        int n = int.Parse(Console.ReadLine());

        int years = n / 12;
        int months = n % 12;

        string yearWord;
        string monthWord;

        if (years % 10 == 1 && years % 100 != 11)
        {
            yearWord = "год";
        }
        else if (years % 10 >= 2 && years % 10 <= 4 && (years % 100 < 10 || years % 100 >= 20))
        {
            yearWord = "года";
        }
        else
        {
            yearWord = "лет";
        }

        if (months % 10 == 1 && months != 11)
        {
            monthWord = "месяц";
        }
        else if (months % 10 >= 2 && months % 10 <= 4 && (months < 10 || months >= 20))
        {
            monthWord = "месяца";
        }
        else
        {
            monthWord = "месяцев";
        }

        if (months == 0)
        {
            Console.WriteLine($"{years} {yearWord} ровно");
        }
        else
        {
            Console.WriteLine($"{years} {yearWord} {months} {monthWord}");
        }
    }
}