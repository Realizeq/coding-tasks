using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите число c: ");
        int c = int.Parse(Console.ReadLine());

        int sum = 0;

        if (a > 0) sum = sum + a;
        if (b > 0) sum = sum + b;
        if (c > 0) sum = sum + c;

        Console.WriteLine($"Сумма положительных чисел: {sum}");
    }
}