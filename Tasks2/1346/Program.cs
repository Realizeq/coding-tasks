using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите s: ");
        int s = int.Parse(Console.ReadLine());

        Console.WriteLine("а) Решения разныме:");
        for (int a = 1; a <= s; a++)
        {
            if (s % a == 0)
            {
                int b = s / a;
                Console.WriteLine($"{a} x {b}");
            }
        }

        Console.WriteLine("б) Решения совпадающие:");
        for (int a = 1; a <= Math.Sqrt(s); a++)
        {
            if (s % a == 0)
            {
                int b = s / a;
                Console.WriteLine($"{a} x {b}");
            }
        }
    }
}