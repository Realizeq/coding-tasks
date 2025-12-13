using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int sum = 0;
        int maxDigit = -1;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                int digit = text[i] - '0';
                sum += digit;

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                }
            }
        }

        Console.WriteLine($"а) Сумма цифр: {sum}");

        if (maxDigit != -1)
        {
            Console.WriteLine($"б) Максимальная цифра: {maxDigit}");
        }
        else
        {
            Console.WriteLine("б) В тексте нет цифр");
        }
    }
}