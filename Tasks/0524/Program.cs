using System;
class Program
{
    static void Main()
    {
        bool found = false;
        int index = 0;

        int prev = int.Parse(Console.ReadLine());

        for (int i = 2; i <= 15; i++)
        {
            int current = int.Parse(Console.ReadLine());

            if (!found && prev == current)
            {
                found = true;
                index = i - 1;
            }

            prev = current;
        }

        if (found) Console.WriteLine($"да, номера {index} и {index + 1}");
        else Console.WriteLine("нет");
    }
}