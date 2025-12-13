using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        Console.Write("Цифры в тексте: ");

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] >= '0' && text[i] <= '9')
            {
                Console.Write(text[i] + " ");
            }
        }
    }
}