using System;
class Program
{
    static void Main()
    {
        int sum = 0;
        int count = 0;

        Console.WriteLine("вводите числа");
        Console.WriteLine("0 стоп");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num == 0) break;

            sum += num;
            count++;
        }

        Console.WriteLine($"сумма: {sum}");
        Console.WriteLine($"количество: {count}");
    }
}