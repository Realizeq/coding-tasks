using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите год: ");
        int g = int.Parse(Console.ReadLine());
        Console.Write("Введите номер месяца: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число: ");
        int n = int.Parse(Console.ReadLine());

        bool isLeapYear = false;
        if (g % 400 == 0)
        {
            isLeapYear = true;
        }
        else if (g % 100 == 0)
        {
            isLeapYear = false;
        }
        else if (g % 4 == 0)
        {
            isLeapYear = true;
        }

        // а) Предыдущий день
        int prevDay = n - 1;
        int prevMonth = m;
        int prevYear = g;

        if (prevDay == 0)
        {
            prevMonth = m - 1;
            if (prevMonth == 0)
            {
                prevMonth = 12;
                prevYear = g - 1;
            }

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
                if (isLeapYear)
                {
                    prevDay = 29;
                }
                else
                {
                    prevDay = 28;
                }
            }
        }

        Console.WriteLine($"а) Предыдущий день/месяц/год: {prevDay}/{prevMonth}/{prevYear}");

        // б) Следующий день
        int nextDay = n + 1;
        int nextMonth = m;
        int nextYear = g;

        int daysInMonth = 0;
        if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
        {
            daysInMonth = 31;
        }
        else if (m == 4 || m == 6 || m == 9 || m == 11)
        {
            daysInMonth = 30;
        }
        else if (m == 2)
        {
            if (isLeapYear)
            {
                daysInMonth = 29;
            }
            else
            {
                daysInMonth = 28;
            }
        }

        if (nextDay > daysInMonth)
        {
            nextDay = 1;
            nextMonth = m + 1;
            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear = g + 1;
            }
        }

        Console.WriteLine($"б) Следующий день/месяц/год: {nextDay}/{nextMonth}/{nextYear}");
    }
}