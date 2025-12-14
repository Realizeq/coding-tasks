using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        if (text.Length == 0)
        {
            Console.WriteLine("Текст пустой");
            return;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < text.Length; i++)
        {
            if (text[i] == text[i - 1])
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 1;
            }
        }

        Console.WriteLine($"Наибольшее количество идущих подряд одинаковых символов: {maxCount}");
    }
}