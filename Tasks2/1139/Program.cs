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

        Console.WriteLine("1) С повторяющимися буквами:");

        for (int i = 0; i < word1.Length; i++)
        {
            if (!word2.Contains(word1[i].ToString()) && !word3.Contains(word1[i].ToString()))
            {
                Console.Write(word1[i] + " ");
            }
        }

        for (int i = 0; i < word2.Length; i++)
        {
            if (!word1.Contains(word2[i].ToString()) && !word3.Contains(word2[i].ToString()))
            {
                Console.Write(word2[i] + " ");
            }
        }

        for (int i = 0; i < word3.Length; i++)
        {
            if (!word1.Contains(word3[i].ToString()) && !word2.Contains(word3[i].ToString()))
            {
                Console.Write(word3[i] + " ");
            }
        }

        Console.WriteLine("\n2) Без повторяющихся букв:");

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

            if (!alreadyPrinted && !word2.Contains(word1[i].ToString()) && !word3.Contains(word1[i].ToString()))
            {
                Console.Write(word1[i] + " ");
            }
        }

        for (int i = 0; i < word2.Length; i++)
        {
            bool alreadyPrinted = false;
            for (int j = 0; j < i; j++)
            {
                if (word2[i] == word2[j])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted && !word1.Contains(word2[i].ToString()) && !word3.Contains(word2[i].ToString()))
            {
                Console.Write(word2[i] + " ");
            }
        }

        for (int i = 0; i < word3.Length; i++)
        {
            bool alreadyPrinted = false;
            for (int j = 0; j < i; j++)
            {
                if (word3[i] == word3[j])
                {
                    alreadyPrinted = true;
                    break;
                }
            }

            if (!alreadyPrinted && !word1.Contains(word3[i].ToString()) && !word2.Contains(word3[i].ToString()))
            {
                Console.Write(word3[i] + " ");
            }
        }
    }
}