using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня года (1-365): ");
        int k = int.Parse(Console.ReadLine());

        // а) 1 января - понедельник
        int dayOfWeekA = (k - 1) % 7;
        string dayNameA;

        switch (dayOfWeekA)
        {
            case 0: dayNameA = "понедельник"; break;
            case 1: dayNameA = "вторник"; break;
            case 2: dayNameA = "среда"; break;
            case 3: dayNameA = "четверг"; break;
            case 4: dayNameA = "пятница"; break;
            case 5: dayNameA = "суббота"; break;
            case 6: dayNameA = "воскресенье"; break;
            default: dayNameA = "ещё раз попробуй давай"; break;
        }

        Console.WriteLine($"а) {k}-й день: {dayNameA}");

        // б) 1 января - d день недели
        Console.Write("Введите день недели 1 января (1-7): ");
        int d = int.Parse(Console.ReadLine());

        int dayOfWeekB = (k - 1 + d - 1) % 7;
        string dayNameB;

        switch (dayOfWeekB)
        {
            case 0: dayNameB = "понедельник"; break;
            case 1: dayNameB = "вторник"; break;
            case 2: dayNameB = "среда"; break;
            case 3: dayNameB = "четверг"; break;
            case 4: dayNameB = "пятница"; break;
            case 5: dayNameB = "суббота"; break;
            case 6: dayNameB = "воскресенье"; break;
            default: dayNameB = "попутал ты"; break;
        }

        Console.WriteLine($"б) {k}-й день: {dayNameB}");
    }
}