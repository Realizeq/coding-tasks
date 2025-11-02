using System;
class Program
{
    static void Main()
    {
        int osadki = 0;

        for (int i = 1; i <= 28; i++)
        {
            Console.Write($"введите осадки за день {i}: ");
            int den = int.Parse(Console.ReadLine());
            osadki += den;
        }

        Console.Write("введите осадки за прошлый год: ");
        int proshly = int.Parse(Console.ReadLine());

        if (osadki > proshly) Console.WriteLine("да");
        else Console.WriteLine("нет");
    }
}