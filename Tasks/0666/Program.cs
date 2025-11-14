using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите v: ");
        int v = int.Parse(Console.ReadLine());

        Console.WriteLine("а) Разные решения:");
        for (int a = 1; a <= v; a++)
        {
            for (int b = 1; b <= v; b++)
            {
                for (int c = 1; c <= v; c++)
                {
                    if (a * b * c == v)
                    {
                        Console.WriteLine($"{a} x {b} x {c}");
                    }
                }
            }
        }

        Console.WriteLine("б) Совпадающие решения:");
        for (int a = 1; a <= v; a++)
        {
            for (int b = a; b <= v; b++)
            {
                for (int c = b; c <= v; c++)
                {
                    if (a * b * c == v)
                    {
                        Console.WriteLine($"{a} x {b} x {c}");
                    }
                }
            }
        }
    }
}