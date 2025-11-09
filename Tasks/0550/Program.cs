using System;
class Program
{
    static void Main()
    {
        int last_index = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"x{i}: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 100 == 12) last_index = i;
        }

        if (last_index > 0) Console.WriteLine($"номер последнего: {last_index}");
        else Console.WriteLine("чисел оканчивающихся на 12 нет");
    }
}