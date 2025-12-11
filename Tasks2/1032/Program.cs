using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        int sentenceCount = 0;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == '!' || text[i] == '?')
            {
                sentenceCount++;
            }
        }

        Console.WriteLine($"Количество предложений: {sentenceCount}");
    }
}