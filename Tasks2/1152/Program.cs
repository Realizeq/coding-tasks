using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        for (int i = 0; i < words.Length - 1; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i].Length > words[j].Length)
                {
                    string temp = words[i];
                    words[i] = words[j];
                    words[j] = temp;
                }
            }
        }

        Console.Write("Слова в порядке неубывания длин: ");
        for (int i = 0; i < words.Length; i++)
        {
            Console.Write(words[i] + " ");
        }
    }
}