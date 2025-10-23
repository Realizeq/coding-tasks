using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (n >= 4): ");
        int n = int.Parse(Console.ReadLine());

        float v1 = 0.0f;
        float v2 = 0.0f;
        float v3 = 1.5f;

        for (int i = 4; i <= n; i++)
        {
            float vNext = (i - 1.0f) / (i * i + 1) * v3 - v2 + v1;
            v1 = v2;
            v2 = v3;
            v3 = vNext;
        }

        Console.WriteLine($"{v3:F4}");
    }
}