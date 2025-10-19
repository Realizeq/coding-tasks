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

        Console.WriteLine("Четное(ые):");
        if (a % 2 == 0)
        {
            Console.WriteLine($"{a}");
        }

        if (b % 2 == 0)
        {
            Console.WriteLine($"{b}");
        }

        if (c % 2 == 0)
        {
            Console.WriteLine($"{c}");
        }
    }
}