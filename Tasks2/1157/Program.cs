using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите последовательность слов: ");
        string posledovatelnost = Console.ReadLine();

        string[] words = posledovatelnost.Split(' ');

        if (words.Length == 0)
        {
            Console.WriteLine("Нет слов");
            return;
        }

        string firstWord = words[0];

        Console.WriteLine("а) Слова без повторяющихся букв:");
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i] != firstWord)
            {
                bool hasDuplicates = false;

                for (int j = 0; j < words[i].Length; j++)
                {
                    for (int k = j + 1; k < words[i].Length; k++)
                    {
                        if (words[i][j] == words[i][k])
                        {
                            hasDuplicates = true;
                            break;
                        }
                    }
                    if (hasDuplicates) break;
                }

                if (!hasDuplicates)
                {
                    Console.Write(words[i] + " ");
                }
            }
        }

        Console.WriteLine();
        Console.WriteLine("б) Симметричные слова:");
        for (int i = 1; i < words.Length; i++)
        {
            if (words[i] != firstWord)
            {
                bool symmetric = true;
                for (int j = 0; j < words[i].Length / 2; j++)
                {
                    if (words[i][j] != words[i][words[i].Length - 1 - j])
                    {
                        symmetric = false;
                        break;
                    }
                }

                if (symmetric)
                {
                    Console.Write(words[i] + " ");
                }
            }
        }
    }
}