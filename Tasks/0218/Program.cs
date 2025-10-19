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

        Console.WriteLine("Числа(о) в интервале [1.6 до 3.8]: ");

        if (a >= 1.6f && a <= 3.8f)
        {
            Console.WriteLine($"{a}");
        }

        if (b >= 1.6f && b <= 3.8f)
        {
            Console.WriteLine($"{b}");
        }

        if (c >= 1.6f && c <= 3.8f)
        {
            Console.WriteLine($"{c}");
        }
    }
}