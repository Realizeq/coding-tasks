using System;
class Program
{
    static void Main()
    {
        float n = 1.5f;

        Console.WriteLine($"n = {n}");
        Console.WriteLine("Поиск первого числа больше n:");

        int count = 1;
        bool found = false;

        while (!found)
        {
            float number;

            if (count == 1)
                number = 1.0f;
            else
                number = 1.0f + 1.0f / count;

            if (number > n)
            {
                Console.WriteLine($"Первое число больше n: {number}");
                found = true;
            }
            count++;
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

            if (current > n)
            {
                Console.WriteLine($"Первое число больше n: {current}");
                break;
            }
        }
    }
}