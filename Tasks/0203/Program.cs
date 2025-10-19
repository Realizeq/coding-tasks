using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите число (1-180): ");
        int k = int.Parse(Console.ReadLine());

        int digit;

        if (k <= 9 * 2)
        {
            // Числа 10-18 (9 по 2)
            int number = 10 + (k - 1) / 2;
            if (k % 2 == 1)
            {
                digit = number / 10; // первая цифра
            }
            else
            {
                digit = number % 10; // вторая цифра
            }
        }
        else
        {
            // Числа 19-99 (81 по 2)
            int position = k - 18; // позиция 19-99
            int number = 19 + (position - 1) / 2;
            if (position % 2 == 1)
            {
                digit = number / 10; // первая цифра
            }
            else
            {
                digit = number % 10; // вторая цифра
            }
        }

        Console.WriteLine($"цифра: {digit}");
    }
}