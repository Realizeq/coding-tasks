using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());

        float a = 1.0f;
        Console.WriteLine($"a1: {a:F4}");

        for (int k = 2; k <= n; k++)
        {
            a = k * a + 1.0f / k;
            Console.WriteLine($"a{k}: {a:F4}");
        }
    }
}