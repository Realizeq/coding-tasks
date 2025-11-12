using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        int n = 2;

        while (true)
        {
            float number = 1.0f + 1.0f / n;

            if (number < a)
            {
                Console.WriteLine($"Наименьшее n: {n}, число = {number}");
                break;
            }
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int i = 2; i <= 100; i++)
        {
            float sum = 1.0f + 1.0f / i;
            if (sum < a)
            {
                Console.WriteLine($"Наименьшее n: {i}, число = {sum}");
                break;
            }
        }
    }
}