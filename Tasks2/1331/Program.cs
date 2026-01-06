using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (9 < a < 10): ");
        float a = float.Parse(Console.ReadLine());

        float sum = 1.0f;
        int n = 1;

        while (sum <= a)
        {
            n++;
            sum += 1.0f / n;
        }

        Console.WriteLine($"Наименьшее n: {n}");
    }
}