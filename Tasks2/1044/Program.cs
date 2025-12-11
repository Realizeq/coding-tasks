using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string word1 = "";
        string word2 = "";
        string currentWord = "";
        int wordCount = 0;

        string[] words = predlozhenie.Split(' ');
        wordCount = words.Length;

        if (wordCount >= 2)
        {
            word1 = words[wordCount - 2];
            word2 = words[wordCount - 1];
        }

        Console.WriteLine($"Предпоследнее слово: {word1}");
        Console.WriteLine($"Последнее слово: {word2}");
    }
}