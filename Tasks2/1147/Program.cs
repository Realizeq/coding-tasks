using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.WriteLine("а) Слова, начинающиеся и оканчивающиеся на одну букву:");
        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0)
            {
                char first = char.ToLower(words[i][0]);
                char last = char.ToLower(words[i][words[i].Length - 1]);

                if (first == last)
                {
                    Console.Write(words[i] + " ");
                }
            }
        }

        Console.WriteLine("б) Слова, которые содержат ровно три буквы 'е':");
        for (int i = 0; i < words.Length; i++)
        {
            int countE = 0;
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == 'е' || words[i][j] == 'Е')
                {
                    countE++;
                }
            }

            if (countE == 3)
            {
                Console.Write(words[i] + " ");
            }
        }

        Console.WriteLine("в) Слова, которые содержат хотя бы одну букву 'о':");
        for (int i = 0; i < words.Length; i++)
        {
            bool hasO = false;
            for (int j = 0; j < words[i].Length; j++)
            {
                if (words[i][j] == 'о' || words[i][j] == 'О')
                {
                    hasO = true;
                    break;
                }
            }

            if (hasO)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}