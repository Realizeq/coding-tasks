using System;
class Program
{
    static void Main()
    {
        bool found = false;
        int index = 0;
        int count = 1;

        int prev = int.Parse(Console.ReadLine());

        while (true)
        {
            int current = int.Parse(Console.ReadLine());
            count++;

            if (current == 9999) break;

            if (!found && prev % 2 == 0 && current % 2 == 0)
            {
                found = true;
                index = count - 1;
            }

            prev = current;
        }

        if (found) Console.WriteLine($"да, номера {index} и {index + 1}");
        else Console.WriteLine("нет");
    }
}