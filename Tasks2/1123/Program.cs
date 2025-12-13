using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int maxCount = 0;
        int currentCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                currentCount++;
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }
            }
            else
            {
                currentCount = 0;
            }
        }

        Console.WriteLine($"Наибольшее количество идущих подряд цифр: {maxCount}");
    }
}