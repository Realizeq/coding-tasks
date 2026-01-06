using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (n > 1): ");
        int n = int.Parse(Console.ReadLine());

        int pred = 1;
        int tek = 1;
        while (tek <= n)
        {
            int sled = pred + tek;
            pred = tek;
            tek = sled;
        }
        Console.WriteLine($"а) Первое число Фибоначи больше {n}: {tek}");

        int sum = 0;
        pred = 1;
        tek = 1;
        while (tek <= 1000)
        {
            sum += tek;
            int sled = pred + tek;
            pred = tek;
            tek = sled;
        }
        Console.WriteLine($"б) Сумма чисел Фибоначи <= 1000: {sum}");
    }
}