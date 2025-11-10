using System;
class Program
{
    static void Main()
    {
        double[] a = new double[15];

        Console.WriteLine("числа a1-a15 (по возрастанию):");
        for (int j = 0; j < 15; j++)
        {
            a[j] = double.Parse(Console.ReadLine());
        }

        Console.Write("число n: ");
        double n = double.Parse(Console.ReadLine());

        int closest_index = 0;
        double min_diff = Math.Abs(a[0] - n);

        for (int j = 1; j < 15; j++)
        {
            double diff = Math.Abs(a[j] - n);
            if (diff < min_diff)
            {
                min_diff = diff;
                closest_index = j;
            }
        }

        Console.WriteLine($"ближайший элемент: номер {closest_index + 1}, значение {a[closest_index]}");
    }
}