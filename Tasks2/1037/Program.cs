using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        int wordCount = 0;
        bool inWord = false;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] != ' ' && !inWord)
            {
                wordCount++;
                inWord = true;
            }
            else if (predlozhenie[i] == ' ')
            {
                inWord = false;
            }
        }

        if (wordCount > 3)
        {
            Console.WriteLine($"Верно, слов больше трех: {wordCount}");
        }
        else
        {
            Console.WriteLine($"Неверно, слов не больше трех: {wordCount}");
        }
    }
}