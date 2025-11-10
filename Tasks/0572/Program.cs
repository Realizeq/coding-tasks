using System;
class Program
{
    static void Main()
    {
        Console.Write("количество судей: ");
        int n = int.Parse(Console.ReadLine());

        double sum = 0;
        double max = double.MinValue;
        double min = double.MaxValue;

        for (int j = 1; j <= n; j++)
        {
            Console.Write($"судья {j}: ");
            double score = double.Parse(Console.ReadLine());

            sum += score;
            if (score > max) max = score;
            if (score < min) min = score;
        }

        double final_score = (sum - max - min) / (n - 2);
        Console.WriteLine($"оценка в зачет: {final_score}");
    }
}