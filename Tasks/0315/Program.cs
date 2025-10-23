using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Введите a: ");
        float a = float.Parse(Console.ReadLine());

        float product = 0.0f;
        for (int i = 0; i < Math.Abs(n); i++)
        {
            product += a;
        }

        if (n < 0)
        {
            product = -product;
        }

        Console.WriteLine($"{product:f2}");
    }
}