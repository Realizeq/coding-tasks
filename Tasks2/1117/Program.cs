using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int startIndex = 0;
        while (startIndex < text.Length && text[startIndex] == ' ')
        {
            startIndex++;
        }

        int maxDigit = -1;
        int maxDigitPosition = -1;
        int positionInText = 1;

        for (int i = startIndex; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                int digit = text[i] - '0';

                if (digit > maxDigit)
                {
                    maxDigit = digit;
                    maxDigitPosition = positionInText;
                }
            }
            positionInText++;
        }

        if (maxDigitPosition != -1)
        {
            Console.WriteLine($"Максимальная цифра: {maxDigit}");
            Console.WriteLine($"Ее порядковый номер (без учета начальных пробелов): {maxDigitPosition}");
        }
        else
        {
            Console.WriteLine("В тексте нет цифр");
        }
    }
}