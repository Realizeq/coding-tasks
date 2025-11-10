using System;
class Program
{
    static void Main()
    {
        int max_even = int.MinValue;

        for (int j = 1; j <= 14; j++)
        {
            Console.Write($"число {j}: ");
            int num = int.Parse(Console.ReadLine());

            if (num % 2 == 0 && num > max_even)
            {
                max_even = num;
            }
        }

        if (max_even != int.MinValue) Console.WriteLine($"максимальное четное: {max_even}");
        else Console.WriteLine("четных чисел нет");
    }
}