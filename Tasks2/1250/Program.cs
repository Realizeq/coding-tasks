using System;
class Program
{
    static int NOD(int a, int b)
    {
        while (b != 0)
        {
            int ost = a % b;
            a = b;
            b = ost;
        }
        return a;
    }

    static void Main()
    {
        Console.Write("Введите числитель: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Введите знаменатель: ");
        int b = int.Parse(Console.ReadLine());

        int del = NOD(a, b);
        int p = a / del;
        int q = b / del;

        Console.WriteLine($"Сокращенная дробь: {p}/{q}");
    }
}