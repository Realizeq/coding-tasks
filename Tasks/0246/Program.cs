using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        int days;

        if (month == 2)
        {
            days = 28;
        }
        else if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            days = 30;
        }
        else
        {
            days = 31;
        }

        Console.WriteLine($"Количество дней: {days}");
    }
}