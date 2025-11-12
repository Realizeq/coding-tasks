using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Числа которые меньше a:");

        int n = 1;

        while (true)
        {
            float number;

            if (n == 1)
                number = 1.0f;
            else
                number = 1.0f + 1.0f / n;

            if (number < a)
            {
                Console.WriteLine($"Число: {number}");
            }
            else
            {
                break;
            }
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int i = 1; i <= 100; i++)
        {
            float current;

            if (i == 1)
                current = 1.0f;
            else
                current = 1.0f + 1.0f / i;

            if (current < a)
                Console.WriteLine($"Число: {current}");
            else
                break;
        }
    }
}