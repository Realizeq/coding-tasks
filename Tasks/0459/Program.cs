using System;
class Program
{
    static void Main()
    {
        double sum = 0;
        int count = 0;

        Console.WriteLine("вводите положительные числа:");
        Console.WriteLine("-1 стоп:");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0) break;

            sum += num;
            count++;
        }

        if (count > 0)
        {
            double srednee = sum / count;
            Console.WriteLine($"среднее арифметическое: {srednee}");
        }
        else
        {
            Console.WriteLine("нет чисел");
        }
    }
}