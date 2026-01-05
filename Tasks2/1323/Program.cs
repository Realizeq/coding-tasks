using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("а) Квадраты ≤ n:");
        int i = 1;
        while (i * i <= n)
        {
            Console.WriteLine(i);
            i++;
        }

        int j = 1;
        while (j * j <= n)
        {
            j++;
        }
        Console.WriteLine($"б) Первое число, квадрат которого > {n}: {j}");
    }
}