using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Введите число (дня): ");
        int n = int.Parse(Console.ReadLine());

        int prevDay = n - 1;
        int prevMonth = m;
        int prevYear = 2017;

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
                    prevDay = 28;
                    break;
            }
        }

        Console.WriteLine($"а) Предыдущий день: {prevDay}.{prevMonth}.{prevYear}");

        int nextDay = n + 1;
        int nextMonth = m;
        int nextYear = 2017;

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
                daysInCurrentMonth = 28;
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