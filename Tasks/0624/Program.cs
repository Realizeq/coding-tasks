using System;
class Program
{
    static void Main()
    {
        float m = 0.8f;

        Console.WriteLine($"m = {m}");
        Console.WriteLine("Числа последовательности меньше m:");

        int n = 1;

        while (true)
        {
            float chislo = (float)n / (n + 1);

            if (chislo >= m)
                break;

            Console.WriteLine($"{n}/{n + 1} = {chislo}");
            n++;
        }

        for (int i = 1; i <= 100; i++)
        {
            float drob = (float)i / (i + 1);
            if (drob < m)
                Console.WriteLine($"{i}/{i + 1} = {drob}");
            else
                break;
        }
    }
}