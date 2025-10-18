using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите второе число: ");
        int n = int.Parse(Console.ReadLine());

        if (n % a == 0)
        {
            Console.WriteLine($"{a} является делителем {n}");
        }
        else
        {
            Console.WriteLine($"{a} не является делителем {n}");
        }
    }
}