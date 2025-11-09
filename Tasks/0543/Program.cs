using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        Console.Write("m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= m; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a % n == 0)
            {
                sum += a;
                count++;
            }
        }

        if (count > 0)
        {
            double average = sum / count;
            Console.WriteLine($"среднее арифметическое: {average}");
        }
        else
        {
            Console.WriteLine("чисел кратных n нет");
        }
    }
}