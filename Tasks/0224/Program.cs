using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введите четвертое число: ");
        int d = int.Parse(Console.ReadLine());

        Console.Write("Введите пятое число: ");
        int e = int.Parse(Console.ReadLine());

        Console.Write("Введите шестое число: ");
        int f = int.Parse(Console.ReadLine());

        int sum = 0;

        if (a > 0) sum = sum + a;
        if (b > 0) sum = sum + b;
        if (c > 0) sum = sum + c;
        if (d > 0) sum = sum + d;
        if (e > 0) sum = sum + e;
        if (f > 0) sum = sum + f;

        Console.WriteLine($"Сумма положительных чисел: {sum}");
    }
}