using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write($"Простые делители числа {n}: ");
        for (int i = 2; i <= n; i++)
        {
            if (n % i == 0)
            {
                bool prostoe = true;
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prostoe = false;
                        break;
                    }
                }
                if (prostoe)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}