using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Введите c: ");
        int c = int.Parse(Console.ReadLine());

        for (int i = a; i <= b; i++)
        {
            if (i % c == 0)
            {
                Console.Write($"{i} ");
            }
        }
    }
}