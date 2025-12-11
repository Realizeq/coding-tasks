using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string firstWord = "";
        bool foundWord = false;

        for (int i = 0; i < predlozhenie.Length; i++)
        {
            if (predlozhenie[i] != ' ' && !foundWord)
            {
                foundWord = true;
            }

            if (foundWord)
            {
                if (predlozhenie[i] != ' ')
                {
                    firstWord += predlozhenie[i];
                }
                else
                {
                    break;
                }
            }
        }

        int count = 0;
        for (int i = 0; i < firstWord.Length; i++)
        {
            if (firstWord[i] == 'о' || firstWord[i] == 'О')
            {
                count++;
            }
        }

        Console.WriteLine($"Первое слово: {firstWord}");
        Console.WriteLine($"Количество букв 'о' в первом слове: {count}");
    }
}