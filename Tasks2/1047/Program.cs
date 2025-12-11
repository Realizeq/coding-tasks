using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        string longestWord = "";

        foreach (string word in words)
        {
            if (word.Length > longestWord.Length)
            {
                longestWord = word;
            }
        }

        Console.WriteLine($"Самое длинное слово: {longestWord}");
    }
}