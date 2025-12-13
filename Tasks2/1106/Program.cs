using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length > 1)
        {
            char lastLetter = word[word.Length - 1];
            string rest = word.Substring(0, word.Length - 1);

            string result = lastLetter + rest;

            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}