using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (n >= 3): ");
        int n = int.Parse(Console.ReadLine());

        // а)
        int a = 1;
        int b = 1;
        int fibN = 0;

        for (int i = 3; i <= n; i++)
        {
            fibN = a + b;
            a = b;
            b = fibN;
        }

        Console.WriteLine($"а) {fibN}");

        // б)
        Console.Write("б) ");
        int a2 = 1;
        int b2 = 1;

        Console.Write("1 1 ");
        for (int i = 3; i <= n; i++)
        {
            int next = a2 + b2;
            Console.Write($"{next} ");
            a2 = b2;
            b2 = next;
        }
    }
}