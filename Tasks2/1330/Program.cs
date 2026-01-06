using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (2 < a < 5): ");
        float a = float.Parse(Console.ReadLine());

        float sum = 1.0f;
        int n = 1;

        while (sum < a)
        {
            Console.WriteLine($"n = {n}");
            n++;
            sum += 1.0f / n;
        }
    }
}