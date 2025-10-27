using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 10; i <= 99; i++)
        {
            if (i % n == 0 || i / 10 == n || i % 10 == n)
            {
                Console.Write($"{i} ");
            }
        }
    }
}