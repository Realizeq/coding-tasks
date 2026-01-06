using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите a (1 < a < 1.5): ");
        float a = float.Parse(Console.ReadLine());
        Console.Write("Введите b (1 < b < 1.5, b > a): ");
        float b = float.Parse(Console.ReadLine());

        int n = 1;
        float c = 2.0f;

        while (c >= b)
        {
            n++;
            c = 1 + 1.0f / n;
        }

        while (c > a)
        {
            Console.WriteLine(c);
            n++;
            c = 1 + 1.0f / n;
        }
    }
}