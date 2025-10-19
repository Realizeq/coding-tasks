using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите третье число: ");
        float c = float.Parse(Console.ReadLine());

        Console.Write("Введите четвертое число: ");
        float d = float.Parse(Console.ReadLine());

        float sum = 0;

        if (a > 5) sum = sum + a;
        if (b > 5) sum = sum + b;
        if (c > 5) sum = sum + c;
        if (d > 5) sum = sum + d;

        Console.WriteLine($"Сумма чисел больше пяти: {sum}");
    }
}