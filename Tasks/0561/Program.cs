using System;
class Program
{
    static void Main()
    {
        int count = 0;
        double prev = double.Parse(Console.ReadLine());

        while (true)
        {
            double current = double.Parse(Console.ReadLine());
            if (current == 1000) break;

            if (current == prev) count++;

            prev = current;
        }

        Console.WriteLine($"количество равных подряд: {count}");
    }
}