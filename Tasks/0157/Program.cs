using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число a: ");
        float a = float.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        float b = float.Parse(Console.ReadLine());

        Console.Write("Введите число c: ");
        float c = float.Parse(Console.ReadLine());

        bool A = a < b && b < c;
        bool B = b > a && a > c;

        if (A && B)
        {
            Console.WriteLine($"Выполняются оба неравенства:");
            Console.WriteLine($"а) a < b < c: {a} < {b} < {c}");
            Console.WriteLine($"б) b > a > c: {b} > {a} > {c}");
        }
        else if (A)
        {
            Console.WriteLine($"а) Выполняется неравенство a < b < c: {a} < {b} < {c}");
        }
        else if (B)
        {
            Console.WriteLine($"б) Выполняется неравенство b > a > c: {b} > {a} > {c}");
        }
        else
        {
            Console.WriteLine("Ни одно из неравенств не выполняется");
        }
    }
}