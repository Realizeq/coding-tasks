using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите годик: ");
        int g = int.Parse(Console.ReadLine());
        Console.Write("Месяц ввел: ");
        int m = int.Parse(Console.ReadLine());
        Console.Write("Введите число дату ну введи давай: ");
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

        int prevDay = n - 1;
        int prevMonth = m;
        int prevYear = g;

        if (prevDay == 0)
        {
            prevMonth--;
            if (prevMonth == 0)
            {
                prevMonth = 12;
                prevYear--;
            }

            switch (prevMonth)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    prevDay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    prevDay = 30;
                    break;
                case 2:
                    prevDay = isLeapYear ? 29 : 28;
                    break;
            }
        }

        Console.WriteLine($"а) Предыдущий день: {prevDay}.{prevMonth}.{prevYear}");

        int nextDay = n + 1;
        int nextMonth = m;
        int nextYear = g;

        int daysInCurrentMonth;
        switch (m)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                daysInCurrentMonth = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                daysInCurrentMonth = 30;
                break;
            case 2:
                daysInCurrentMonth = isLeapYear ? 29 : 28;
                break;
            default:
                daysInCurrentMonth = 0;
                break;
        }

        if (nextDay > daysInCurrentMonth)
        {
            nextDay = 1;
            nextMonth++;
            if (nextMonth > 12)
            {
                nextMonth = 1;
                nextYear++;
            }
        }

        Console.WriteLine($"б) Следующий день: {nextDay}.{nextMonth}.{nextYear}");
    }
}