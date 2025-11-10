using System;
class Program
{
    static void Main()
    {
        bool found = false;
        int index = 0;

        for (int j = 1; j <= 12; j++)
        {
            Console.Write($"b{j}: ");
            int b = int.Parse(Console.ReadLine());

            if (!found && b % 10 == 7)
            {
                found = true;
                index = j;
            }
        }

        if (found) Console.WriteLine($"да, номер первого: {index}");
        else Console.WriteLine("нет");
    }
}