using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Буквы, встречающиеся в обоих словах по одному разу: ");

        for (int i = 0; i < word1.Length; i++)
        {
            int countInWord1 = 0;
            for (int j = 0; j < word1.Length; j++)
            {
                if (word1[i] == word1[j])
                {
                    countInWord1++;
                }
            }

            int countInWord2 = 0;
            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    countInWord2++;
                }
            }

            if (countInWord1 == 1 && countInWord2 == 1)
            {
                bool alreadyPrinted = false;
                for (int j = 0; j < i; j++)
                {
                    if (word1[i] == word1[j])
                    {
                        alreadyPrinted = true;
                        break;
                    }
                }

                if (!alreadyPrinted)
                {
                    Console.Write(word1[i] + " ");
                }
            }
        }
    }
}