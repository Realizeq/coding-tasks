using System;
class Program
{
    static void Main()
    {
        int last_index = 0;

        Console.Write("k: ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= k; i++)
        {
            Console.Write($"b{i}: ");
            int b = int.Parse(Console.ReadLine());

            if (b < 0) last_index = i;
        }

        Console.WriteLine($"номер последнего отрицательного: {last_index}");
    }
}