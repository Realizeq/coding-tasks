using System;
class Program
{
    static void Main()
    {
        double[] y = new double[15];

        Console.WriteLine("числа y1-y15 (по возрастанию):");
        for (int j = 0; j < 15; j++)
        {
            y[j] = double.Parse(Console.ReadLine());
        }

        Console.Write("число n: ");
        double n = double.Parse(Console.ReadLine());

        // а)
        double sum = 0;
        int k = 0;
        while (k < 15 && y[k] < n)
        {
            sum += y[k];
            k++;
        }
        Console.WriteLine($"сумма чисел меньших n: {sum}");

        // б)
        int index = 0;
        while (index < 14 && !(y[index] < n && n < y[index + 1]))
        {
            index++;
        }
        Console.WriteLine($"между элементами {index + 1} и {index + 2}");
        Console.WriteLine($"значения: {y[index]} и {y[index + 1]}");
    }
}