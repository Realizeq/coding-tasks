using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("а) Сумма чисел Фибоначчи не превосходящих 1000:");

        int fib1 = 1;
        int fib2 = 1;
        int sum = fib1 + fib2;

        while (true)
        {
            int next = fib1 + fib2;
            if (next > 1000)
                break;

            sum += next;
            fib1 = fib2;
            fib2 = next;
        }

        Console.WriteLine($"Сумма = {sum}");

        Console.WriteLine("б) Первое число Фибоначчи большее n:");
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        fib1 = 1;
        fib2 = 1;

        while (fib2 <= n)
        {
            int next = fib1 + fib2;
            fib1 = fib2;
            fib2 = next;
        }

        Console.WriteLine($"Первое число больше {n}: {fib2}");

        Console.Write("Введите n для второго варианта: ");
        n = int.Parse(Console.ReadLine());

        int a = 1;
        int b = 1;

        for (int i = 3; i <= 100; i++)
        {
            int c = a + b;
            if (c > n)
            {
                Console.WriteLine($"Первое число больше {n}: {c}");
                break;
            }
            a = b;
            b = c;
        }
    }
}