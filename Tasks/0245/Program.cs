using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер месяца (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Год високосный? (да/нет): ");
        string isLeap = Console.ReadLine();
        bool Year = isLeap.ToLower() == "да";

        int days;

        switch (month)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                days = 31;
                break;
            case 4:
            case 6:
            case 9:
            case 11:
                days = 30;
                break;
            case 2:
                if (Year)
                {
                    days = 29;
                }
                else
                {
                    days = 28;
                }
                break;
            default:
                days = -1; // попутал че то
                break;
        }

        if (days == -1)
        {
            Console.WriteLine("Неверный номер месяца");
        }
        else
        {
            Console.WriteLine($"Количество дней: {days}");
        }
    }
}