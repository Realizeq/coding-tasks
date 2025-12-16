using System;
class Program
{
    static void Main()
    {
        int[] chasy = {10, 15, 8, 22, 13, 9, 16, 11, 20, 14,
                      7, 18, 12, 17, 19, 6, 21, 23, 5, 4,
                      3, 2, 1, 0};

        int[] minuty = {30, 15, 45, 10, 20, 55, 5, 40, 25, 50,
                       35, 0, 10, 45, 30, 15, 40, 20, 55, 5,
                       50, 35, 25, 0};

        int[] sekundy = {15, 30, 10, 45, 20, 5, 50, 35, 25, 0,
                        40, 55, 15, 30, 10, 45, 20, 5, 50, 35,
                        25, 0, 40, 55};

        Console.Write("Введите номер первого момента времени (1-24): ");
        int n1 = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Введите номер второго момента времени (1-24): ");
        int n2 = int.Parse(Console.ReadLine()) - 1;

        if (n1 < 0 || n1 >= 24 || n2 < 0 || n2 >= 24)
        {
            Console.WriteLine("Некорректные номера");
            return;
        }

        int time1 = chasy[n1] * 3600 + minuty[n1] * 60 + sekundy[n1];
        int time2 = chasy[n2] * 3600 + minuty[n2] * 60 + sekundy[n2];

        Console.WriteLine($"Момент 1: {chasy[n1]:D2}:{minuty[n1]:D2}:{sekundy[n1]:D2}");
        Console.WriteLine($"Момент 2: {chasy[n2]:D2}:{minuty[n2]:D2}:{sekundy[n2]:D2}");

        if (time1 < time2)
        {
            Console.WriteLine("Первый момент был раньше");
        }
        else if (time2 < time1)
        {
            Console.WriteLine("Второй момент был раньше");
        }
        else
        {
            Console.WriteLine("Моменты времени одинаковы");
        }
    }
}