using System;
class Program
{
    static void Main()
    {
        bool ordered = true;
        int index = 0;

        double prev = double.Parse(Console.ReadLine());

        for (int i = 2; i <= 15; i++)
        {
            double current = double.Parse(Console.ReadLine());

            if (ordered && current <= prev)
            {
                ordered = false;
                index = i;
            }

            prev = current;
        }

        if (ordered) Console.WriteLine("да");
        else Console.WriteLine($"нет, номер {index}");
    }
}