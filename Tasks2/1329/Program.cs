using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (4 < a < 6): ");
        float a = float.Parse(Console.ReadLine());

        float sum = 1.0f;
        int n = 2;

        while (sum <= a)
        {
            sum += 1.0f / n;
            n++;
        }

        Console.WriteLine($"Первое число большее {a}: {sum}");
    }
}