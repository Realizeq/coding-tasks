using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите номер дня (от 1 до 365): ");
        int k = int.Parse(Console.ReadLine());

        int dayOfWeek = k % 7;

        if (dayOfWeek == 6 || dayOfWeek == 0)
        {
            Console.WriteLine($"{k}-й день года является выходным");
        }
        else
        {
            Console.WriteLine($"{k}-й день года является рабочим");
        }
    }
}