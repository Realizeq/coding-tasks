using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.Write("Слова, встречающиеся по одному разу: ");

        for (int i = 0; i < words.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}