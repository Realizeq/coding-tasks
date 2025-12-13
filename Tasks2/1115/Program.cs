using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int count = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                count++;
            }
        }

        Console.WriteLine($"Количество цифр в тексте: {count}");
    }
}