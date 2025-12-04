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
        Console.WriteLine($"Количество слов (случай 1): {wordCount}");

        string trimmedPredlozhenie = predlozhenie.Trim();
        int wordCount2 = 0;
        bool inWord2 = false;

        for (int i = 0; i < trimmedPredlozhenie.Length; i++)
        {
            if (trimmedPredlozhenie[i] != ' ' && !inWord2)
            {
                wordCount2++;
                inWord2 = true;
            }
            else if (trimmedPredlozhenie[i] == ' ')
            {
                inWord2 = false;
            }
        }
        Console.WriteLine($"Количество слов (случай 2): {wordCount2}");
    }
}