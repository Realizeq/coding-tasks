using System;
class Program
{
    static void Main()
    {
        int sum = 0;

        Console.WriteLine("вводите числа:");

        while (true)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0) break;
            sum += num;
        }

        Console.WriteLine($"сумма нечетных чисел в начале: {sum}");
    }
}