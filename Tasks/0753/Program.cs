using System;
class Program
{
    static void Main()
    {
        int[] a = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

        Console.WriteLine("Массив:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine($"{a[i]}");
        }

        int znakoperemennayaSumma = 0;
        int znak = 1;

        for (int i = 0; i < a.Length; i++)
        {
            znakoperemennayaSumma += znak * a[i];
            znak = -znak;
        }

        Console.WriteLine($"Знакопеременная сумма: {znakoperemennayaSumma}");
    }
}