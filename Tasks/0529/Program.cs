using System;
class Program
{
    static void Main()
    {
        bool ordered = true;
        int index = 0;
        int count = 1;

        double prev = double.Parse(Console.ReadLine());

        while (true)
        {
            double current = double.Parse(Console.ReadLine());
            count++;

            if (current == 10000) break;

            if (ordered && current <= prev)
            {
                ordered = false;
                index = count;
            }

            prev = current;
        }

        if (ordered) Console.WriteLine("да");
        else Console.WriteLine($"нет, номер {index}");
    }
}