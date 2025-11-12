using System;
class Program
{
    static void Main()
    {
        float a = 2.0f;

        Console.WriteLine($"a = {a}");
        Console.WriteLine("Значения n где сумма больше a:");

        int n = 1;

        while (true)
        {
            float sum = 0.0f;

            for (int i = 1; i <= n; i++)
            {
                sum += 1.0f / i;
            }

            if (sum > a)
            {
                Console.WriteLine($"n = {n}, сумма = {sum}");
            }
            else if (n > 100)
            {
                break;
            }
            n++;
        }

        Console.WriteLine();

        Console.WriteLine("Второй вариант:");

        for (int currentN = 1; currentN <= 50; currentN++)
        {
            float currentSum = 0.0f;

            for (int i = 1; i <= currentN; i++)
            {
                currentSum += 1.0f / i;
            }

            if (currentSum > a)
            {
                Console.WriteLine($"n = {currentN}, сумма = {currentSum}");
            }
        }
    }
}