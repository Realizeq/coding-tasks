using System;
class Program
{
    static void Main()
    {
        bool found = false;
        int index = 0;

        for (int j = 1; j <= 15; j++)
        {
            Console.Write($"a{j}: ");
            double a = double.Parse(Console.ReadLine());

            if (!found && a < 0)
            {
                found = true;
                index = j;
            }
        }

        if (found) Console.WriteLine($"да, номер первого: {index}");
        else Console.WriteLine("нет");
    }
}