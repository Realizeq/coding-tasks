using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Буквы, которые есть только в одном слове: ");

        for (int i = 0; i < word1.Length; i++)
        {
            bool foundInWord2 = false;

            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    foundInWord2 = true;
                    break;
                }
            }

            if (!foundInWord2)
            {
                Console.Write(word1[i] + " ");
            }
        }

        for (int i = 0; i < word2.Length; i++)
        {
            bool foundInWord1 = false;

            for (int j = 0; j < word1.Length; j++)
            {
                if (word2[i] == word1[j])
                {
                    foundInWord1 = true;
                    break;
                }
            }

            if (!foundInWord1)
            {
                Console.Write(word2[i] + " ");
            }
        }
    }
}