using System;
class Program
{
    static void Main()
    {
        double min_current = double.MaxValue;
        int min_index = 0;

        for (int j = 1; j <= 20; j++)
        {
            Console.Write($"сопротивление {j} - напряжение Ватт: ");
            double voltage = double.Parse(Console.ReadLine());

            Console.Write($"сопротивление {j} - сопротивление Омы: ");
            double resistance = double.Parse(Console.ReadLine());

            double current = voltage / resistance;

            if (current < min_current)
            {
                min_current = current;
                min_index = j;
            }
        }

        Console.WriteLine($"сопротивление с минимальным током: {min_index}");
    }
}