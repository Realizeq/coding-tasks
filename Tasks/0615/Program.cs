using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Поиск первого числа меньше a:");

        int n = 2;
        bool found = false;

        while (!found)
        {
            float number = 1.0f + 1.0f / n;

            if (number < a)
            {
                Console.WriteLine($"Первое число меньше a: 1 + 1/{n} = {number}");
                found = true;
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
                Console.WriteLine($"Первое число меньше a: 1 + 1/{i} = {sum}");
                break;
            }
        }
    }
}