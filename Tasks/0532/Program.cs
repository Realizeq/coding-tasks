using System;
class Program
{
    static void Main()
    {
        bool all_equal = true;

        Console.Write("число 1: ");
        int first = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 12; i++)
        {
            Console.Write($"число {i}: ");
            int current = int.Parse(Console.ReadLine());

            if (current != first) all_equal = false;
        }

        if (all_equal) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}