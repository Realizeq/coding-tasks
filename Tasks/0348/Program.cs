using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i * i <= n; i++)
        {
            Console.Write($"{i} ");
        }
    }
}