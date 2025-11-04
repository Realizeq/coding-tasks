using System;
class Program
{
    static void Main()
    {
        int even = 0;
        int odd = 0;

        for (int i = 1; i <= 28; i++)
        {
            Console.Write($"день {i}: ");
            int osadki = int.Parse(Console.ReadLine());

            if (i % 2 == 0) even += osadki;
            else odd += osadki;
        }

        if (even > odd) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}