using System;
class Program
{
    static void Main()
    {
        string word = "иинформаця";

        string result = word[0].ToString() + word.Substring(2, 7) + word[1] + word[9];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Исправленное слово: {result}");
    }
}