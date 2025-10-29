using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        int count0 = 0;
        int count9 = 0;

        int temp = number;
        while (temp > 0)
        {
            int digit = temp % 10;

            if (digit == 0) count0++;
            if (digit == 9) count9++;

            temp /= 10;
        }

        if (count0 > count9)
        {
            Console.WriteLine("0");
        }
        else if (count9 > count0)
        {
            Console.WriteLine("9");
        }
        else
        {
            Console.WriteLine("Одинаково");
        }
    }
}