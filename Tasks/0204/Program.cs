using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите n (1-32): ");
        int n = int.Parse(Console.ReadLine());

        int digit;

        if (n == 1)
        {
            digit = 0; // первая цифра 0
        }
        else if (n <= 3)
        {
            // Число 1 (2-3)
            if (n == 2)
                digit = 1;
            else
                digit = 0;
        }
        else if (n <= 20)
        {
            // Числа 2-9 (8 по 1)
            digit = n - 2;
        }
        else
        {
            // Числа 10-20 (11 по 2)
            int position = n - 20;
            int number = 10 + (position - 1) / 2;

            if (position % 2 == 1)
            {
                digit = number / 10; // первая цифра
            }
            else
            {
                digit = number % 10; // вторая цифра
            }
        }

        Console.WriteLine($"n-я цифра: {digit}");
    }
}