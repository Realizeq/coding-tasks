using System;
class Program
{
    static void Main()
    {
        bool found = false;

        Console.Write("количество чисел: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"число {i}: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0) found = true;
        }

        if (found) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}