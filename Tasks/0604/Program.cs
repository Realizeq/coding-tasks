using System;
class Program
{
    static void Main()
    {
        int max_count = 4;
        int max_value = 8;

        Console.Write("A: ");
        int A = int.Parse(Console.ReadLine());

        if (A > max_value)
        {
            max_count = 1;
            max_value = A;
        }
        else if (A == max_value)
        {
            max_count++;
        }

        Console.WriteLine($"максимальных элементов: {max_count}");
        Console.WriteLine($"максимальное значение: {max_value}");
    }
}