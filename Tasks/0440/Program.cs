using System;
class Program
{
    static void Main()
    {
        int proizvedenie = 1;

        Console.WriteLine("вводите положительные числа");
        Console.WriteLine("0 стоп");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 0) break;
            if (num > 0) proizvedenie *= num;
        }

        Console.WriteLine($"произведение положительных чисел: {proizvedenie}");
    }
}