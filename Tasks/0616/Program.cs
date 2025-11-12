using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Все значения n где числа не меньше a:");

        int n = 2;

        while (true)
        {
            float number = 1.0f + 1.0f / n;

            if (number < a)
                break;

            Console.WriteLine($"n = {n}, число = {number}");
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int i = 2; i <= 100; i++)
        {
            float sum = 1.0f + 1.0f / i;
            if (sum >= a)
                Console.WriteLine($"n = {i}, число = {sum}");
            else
                break;
        }
    }
}