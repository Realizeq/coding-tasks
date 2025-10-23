using System;
class Program
{
    static void Main()
    {
        float deposit = 1000.0f;

        // а)
        Console.WriteLine("а) Прирост вклада:");
        for (int month = 1; month <= 10; month++)
        {
            float increase = deposit * 0.02f;
            deposit += increase;
            Console.WriteLine($"{month} месяц - {increase:F2} руб");
        }

        // б)
        deposit = 1000.0f;
        Console.WriteLine("б) Сумма вклада:");
        for (int month = 1; month <= 12; month++)
        {
            deposit *= 1.02f;
            if (month >= 3)
            {
                Console.WriteLine($"{month} месяцев - {deposit:F2} руб");
            }
        }
    }
}