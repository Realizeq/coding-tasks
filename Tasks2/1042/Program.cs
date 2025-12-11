using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string lastWord = "";
        string currentWord = "";

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
                    lastWord = currentWord;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > 0)
        {
            lastWord = currentWord;
        }

        Console.WriteLine($"Последнее слово: {lastWord}");
    }
}