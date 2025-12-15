using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.WriteLine("а) Замена первой 'а' на 'о':");
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string result = "";
            bool replaced = false;

            for (int j = 0; j < word.Length; j++)
            {
                if (!replaced && (word[j] == 'а' || word[j] == 'А'))
                {
                    result += word[j] == 'а' ? 'о' : 'О';
                    replaced = true;
                }
                else
                {
                    result += word[j];
                }
            }
            Console.Write(result + " ");
        }

        Console.WriteLine();
        Console.WriteLine("б) Удаление всех вхождений последней буквы:");
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            if (word.Length == 0) continue;

            char lastLetter = word[word.Length - 1];
            string result = "";

            for (int j = 0; j < word.Length - 1; j++)
            {
                if (word[j] != lastLetter)
                {
                    result += word[j];
                }
            }
            result += lastLetter;
            Console.Write(result + " ");
        }

        Console.WriteLine();
        Console.WriteLine("в) Только первые вхождения каждой буквы:");
        for (int i = 0; i < words.Length; i++)
        {
            string word = words[i];
            string result = "";

            for (int j = 0; j < word.Length; j++)
            {
                bool alreadyExists = false;
                for (int k = 0; k < j; k++)
                {
                    if (word[j] == word[k])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    result += word[j];
                }
            }
            Console.Write(result + " ");
        }

        Console.WriteLine();
        Console.WriteLine("г) Удаление средней буквы в самом длинном слове:");
        string longestWord = "";
        int longestIndex = -1;

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
                longestIndex = i;
            }
        }

        for (int i = 0; i < words.Length; i++)
        {
            if (i == longestIndex)
            {
                string word = words[i];
                string result = "";

                if (word.Length % 2 == 1)
                {
                    int middle = word.Length / 2;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j != middle)
                        {
                            result += word[j];
                        }
                    }
                }
                else
                {
                    int middle1 = word.Length / 2 - 1;
                    int middle2 = word.Length / 2;
                    for (int j = 0; j < word.Length; j++)
                    {
                        if (j != middle1 && j != middle2)
                        {
                            result += word[j];
                        }
                    }
                }
                Console.Write(result + " ");
            }
            else
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}