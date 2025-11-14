using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("а) Разные решения:");
        for (int a = 1; a <= s; a++)
        {
            for (int b = 1; b <= s; b++)
            {
                if (a * b == s)
                {
                    Console.WriteLine($"{a} x {b}");
                }
            }
        }

        Console.WriteLine("б) Совпадающие решения:");
        for (int a = 1; a <= s; a++)
        {
            for (int b = a; b <= s; b++)
            {
                if (a * b == s)
                {
                    Console.WriteLine($"{a} x {b}");
                }
            }
        }
    }
}