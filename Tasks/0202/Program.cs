using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня (1-365): ");
        int k = int.Parse(Console.ReadLine());

        // а) 1 января понедельник
        int dayOfWeekA = (k - 1) % 7 + 1;

        string dayNameA;
        if (dayOfWeekA == 6)
        {
            dayNameA = "суббота";
        }
        else if (dayOfWeekA == 7)
        {
            dayNameA = "воскресенье";
        }
        else
        {
            dayNameA = "рабочий день";
        }

        // б) 1 января d-й день недели
        Console.Write("Введите день недели (1-7): ");
        int d = int.Parse(Console.ReadLine());

        int dayOfWeekB = (k - 1 + d - 1) % 7 + 1;

        string dayNameB;
        if (dayOfWeekB == 6)
        {
            dayNameB = "суббота";
        }
        else if (dayOfWeekB == 7)
        {
            dayNameB = "воскресенье";
        }
        else
        {
            dayNameB = "рабочий день";
        }

        Console.WriteLine($"а) {k} день года: {dayNameA}");
        Console.WriteLine($"б) {k} день года: {dayNameB}");
    }
}