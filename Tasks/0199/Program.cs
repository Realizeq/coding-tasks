using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        // а) Предыдущий день
        int prevDay = n - 1;
        int prevMonth = m;

        if (prevDay == 0)
        {
            prevMonth = m - 1;
            if (prevMonth == 1 || prevMonth == 3 || prevMonth == 5 || prevMonth == 7 ||
                prevMonth == 8 || prevMonth == 10 || prevMonth == 12)
            {
                prevDay = 31;
            }
            else if (prevMonth == 4 || prevMonth == 6 || prevMonth == 9 || prevMonth == 11)
            {
                prevDay = 30;
            }
            else if (prevMonth == 2)
            {
                prevDay = 28;
            }
        }

        Console.WriteLine($"а) Предыдущий день/месяц: {prevDay}/{prevMonth}");

        // б) Следующий день
        int nextDay = n + 1;
        int nextMonth = m;

        if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
        {
            if (nextDay > 31)
            {
                nextDay = 1;
                nextMonth = m + 1;
            }
        }
        else if (m == 4 || m == 6 || m == 9 || m == 11)
        {
            if (nextDay > 30)
            {
                nextDay = 1;
                nextMonth = m + 1;
            }
        }
        else if (m == 2)
        {
            if (nextDay > 28)
            {
                nextDay = 1;
                nextMonth = m + 1;
            }
        }

        Console.WriteLine($"б) Следующий день/месяц : {nextDay}/{nextMonth}");
    }
}