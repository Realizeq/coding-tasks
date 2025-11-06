using System;
class Program
{
    static void Main()
    {
        int count = 0;

        Console.WriteLine("вводите числа:");

        while (true)
        {
            double num = double.Parse(Console.ReadLine());
            if (num == 0) break;
            count++;
        }

        Console.WriteLine($"чисел до первого нуля: {count}");
    }
}