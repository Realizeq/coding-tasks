using System;
class Program
{
    static void Main()
    {
        int min_len = int.MaxValue;
        int current_len = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        for (int j = 1; j <= m; j++)
        {
            Console.Write($"число {j}: ");
            int num = int.Parse(Console.ReadLine());

            if (num == 0)
            {
                current_len++;
            }
            else
            {
                if (current_len > 0 && current_len < min_len) min_len = current_len;
                current_len = 0;
            }
        }

        if (current_len > 0 && current_len < min_len) min_len = current_len;

        if (min_len == int.MaxValue) Console.WriteLine("нулей нет");
        else Console.WriteLine($"наименьшая длина отрезка: {min_len}");
    }
}