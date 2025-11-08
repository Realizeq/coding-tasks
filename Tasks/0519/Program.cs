using System;
class Program
{
    static void Main()
    {
        int count = 0;

        for (int i = 1; i <= 31; i++)
        {
            Console.Write($"день {i}: ");
            int osadki = int.Parse(Console.ReadLine());

            if (osadki == 0) count++;
        }

        if (count == 10) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}