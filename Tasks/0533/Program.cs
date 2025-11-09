using System;
class Program
{
    static void Main()
    {
        bool all_equal = true;

        Console.Write("число 1: ");
        int first = int.Parse(Console.ReadLine());

        int i = 2;
        while (true)
        {
            Console.Write($"число {i}: ");
            int current = int.Parse(Console.ReadLine());

            if (current < 0) break;

            if (current != first) all_equal = false;

            i++;
        }

        if (all_equal) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}