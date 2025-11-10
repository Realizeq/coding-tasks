using System;
class Program
{
    static void Main()
    {
        int count = 1;
        double prev = double.Parse(Console.ReadLine());

        while (true)
        {
            double current = double.Parse(Console.ReadLine());
            if (current == 0) break;

            if (current != prev) count++;

            prev = current;
        }

        Console.WriteLine($"количество различных чисел: {count}");
    }
}