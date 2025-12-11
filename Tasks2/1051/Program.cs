using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите текст: ");
        string text = Console.ReadLine();

        string firstSentence = "";
        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == '.' || text[i] == '!' || text[i] == '?')
            {
                firstSentence = text.Substring(0, i + 1);
                break;
            }
        }

        if (firstSentence.Length == 0)
        {
            firstSentence = text;
        }

        int count = 0;
        for (int i = 0; i < firstSentence.Length; i++)
        {
            if (firstSentence[i] == 'и' || firstSentence[i] == 'И')
            {
                count++;
            }
        }

        Console.WriteLine($"В первом предложении букв 'и': {count}");

        bool hasI = count > 0;
        if (hasI)
        {
            Console.WriteLine("Буквы 'и' есть в первом предложении");
        }
        else
        {
            Console.WriteLine("Букв 'и' нет в первом предложении");
        }
    }
}