using System;
class Program
{
    static void Main()
    {
        double min_temp = double.MaxValue;
        int count = 0;

        Console.Write("количество дней: ");
        int n = int.Parse(Console.ReadLine());

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"день {j}: ");
            double temp = double.Parse(Console.ReadLine());

            if (temp < min_temp)
            {
                min_temp = temp;
                count = 1;
            }
            else if (temp == min_temp)
            {
                count++;
            }
        }

        Console.WriteLine($"дней с минимальной температурой {count}");
    }
}