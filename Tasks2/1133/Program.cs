using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        char duplicateLetter = '\0';

        for (int i = 0; i < word.Length; i++)
        {
            for (int j = i + 1; j < word.Length; j++)
            {
                if (word[i] == word[j])
                {
                    duplicateLetter = word[i];
                    break;
                }
            }
            if (duplicateLetter != '\0')
            {
                break;
            }
        }

        if (duplicateLetter != '\0')
        {
            Console.WriteLine($"Две одинаковые буквы: {duplicateLetter}");
        }
        else
        {
            Console.WriteLine("В слове нет двух одинаковых букв");
        }
    }
}