using System;
class Program
{
    static void Main()
    {
        int[] massiv = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120 };

        int summa = 0;
        for (int i = 1; i < massiv.Length; i += 2)
        {
            summa += massiv[i];
        }

        Console.WriteLine($"Сумма элементов с четными индексами: {summa}");
    }
}