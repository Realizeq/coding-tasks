using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        Console.Write("n: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 12; i++)
        {
            Console.Write($"a{i}: ");
            int a = int.Parse(Console.ReadLine());

            if (a > n)
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
            Console.WriteLine("чисел больше n нет");
        }
    }
}