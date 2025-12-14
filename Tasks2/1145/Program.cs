using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        Console.Write("Слова, отличные от 'привет': ");

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i] != "привет")
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}