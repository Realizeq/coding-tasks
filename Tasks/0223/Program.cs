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

        int sum = 0;

        if (a % 3 == 0) sum = sum + a;
        if (b % 3 == 0) sum = sum + b;
        if (c % 3 == 0) sum = sum + c;
        if (d % 3 == 0) sum = sum + d;

        Console.WriteLine($"Сумма чисел кратных трем: {sum}");
    }
}