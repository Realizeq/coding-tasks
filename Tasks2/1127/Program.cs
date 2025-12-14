using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите натуральное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0) number = -number;

        int count = 0;

        if (number == 0)
        {
            count = 1;
        }
        else
        {
            while (number > 0)
            {
                count++;
                number = number / 10;
            }
        }

        Console.WriteLine($"Количество цифр в числе: {count}");
    }
}