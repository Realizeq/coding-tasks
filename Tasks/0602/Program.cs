using System;
class Program
{
    static void Main()
    {
        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n];

        for (int j = 0; j < n; j++)
        {
            Console.Write($"спортсмен {j + 1}: ");
            a[j] = int.Parse(Console.ReadLine());
        }

        for (int j = 0; j < n - 1; j++)
        {
            for (int k = j + 1; k < n; k++)
            {
                if (a[k] < a[j])
                {
                    int temp = a[j];
                    a[j] = a[k];
                    a[k] = temp;
                }
            }
        }

        Console.WriteLine("команда из четырех лучших:");
        Console.WriteLine($"1: {a[0]}");
        Console.WriteLine($"2: {a[1]}");
        Console.WriteLine($"3: {a[2]}");
        Console.WriteLine($"4: {a[3]}");
        Console.WriteLine($"сумма результатов: {a[0] + a[1] + a[2] + a[3]}");
    }
}