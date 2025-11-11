using System;
class Program
{
    static void Main()
    {
        float a = 1.2f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Числа которые больше a:");

        int n = 2;

        while (true)
        {
            float number = 1.0f + 1.0f / n;

            if (number < a)
                break;

            Console.WriteLine($"1 + 1/{n} = {number}");
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int i = 2; i <= 20; i++)
        {
            float sum = 1.0f + 1.0f / i;
            if (sum >= a)
                Console.WriteLine($"1 + 1/{i} = {sum}");
            else
                break;
        }

        Console.WriteLine();

        Console.WriteLine("Третий вариант:");

        int currentN = 2;
        float currentSum;

        do
        {
            currentSum = 1.0f + 1.0f / currentN;
            if (currentSum >= a)
                Console.WriteLine($"1 + 1/{currentN} = {currentSum}");
            currentN++;
        }
        while (currentSum >= a);
    }
}