using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string word1 = "";
        string word2 = "";
        string word3 = "";
        string currentWord = "";
        int wordCount = 0;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] != ' ')
            {
                currentWord += predlozhenie[i];
            }
            else
            {
                if (currentWord.Length > 0)
                {
                    wordCount++;
                    if (wordCount == 1) word1 = currentWord;
                    else if (wordCount == 2) word2 = currentWord;
                    else if (wordCount == 3) word3 = currentWord;
                    currentWord = "";
                }
            }
        }

        if (currentWord.Length > 0 && wordCount < 3)
        {
            wordCount++;
            if (wordCount == 1) word1 = currentWord;
            else if (wordCount == 2) word2 = currentWord;
            else if (wordCount == 3) word3 = currentWord;
        }

        Console.WriteLine($"Первое слово: {word1}");
        Console.WriteLine($"Второе слово: {word2}");
        Console.WriteLine($"Третье слово: {word3}");
    }
}