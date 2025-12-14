using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Введите третье слово: ");
        string word3 = Console.ReadLine();

        Console.Write("Общие буквы: ");

        for (int i = 0; i < word1.Length; i++)
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

            if (alreadyPrinted) continue;

            bool inWord2 = false;
            bool inWord3 = false;

            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    inWord2 = true;
                    break;
                }
            }

            for (int j = 0; j < word3.Length; j++)
            {
                if (word1[i] == word3[j])
                {
                    inWord3 = true;
                    break;
                }
            }

            if (inWord2 && inWord3)
            {
                Console.Write(word1[i] + " ");
            }
        }
    }
}