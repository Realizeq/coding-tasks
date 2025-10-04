using System;
class program
{
    static void Main()
    {
        Console.Write("Введите стоимость 1 кг конфет: ");
        float candyPrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите стоимость 1 кг печенья: ");
        float cookiePrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите стоимость 1 кг яблок: ");
        float applePrice = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество кг конфет: ");
        float candyKg = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество кг печенья: ");
        float cookieKg = Convert.ToSingle(Console.ReadLine());

        Console.Write("Введите количество кг яблок: ");
        float appleKg = Convert.ToSingle(Console.ReadLine());

        float totalCost = candyPrice * candyKg + cookiePrice * cookieKg + applePrice * appleKg;

        Console.WriteLine($"Общая стоимость покупки: {totalCost:F2} руб.");
    }
}