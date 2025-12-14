using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение из 10 слов: ");
        string predlozhenie = Console.ReadLine();

        string[] words = new string[10];
        string currentWord = "";
        int wordIndex = 0;

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
                    words[wordIndex] = currentWord;
                    wordIndex++;
                    currentWord = "";
                }
            }
        }

        if (currentWord.Length > 0 && wordIndex < 10)
        {
            words[wordIndex] = currentWord;
        }

        Console.WriteLine("Массив слов:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"words[{i}] = {words[i]}");
        }
    }
}