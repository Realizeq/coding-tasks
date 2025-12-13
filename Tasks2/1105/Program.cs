using System;
class Program
{
    static void Main()
    {
        string word = "роцессорп";

        string result = word[4].ToString() + word.Substring(0, 4) + word.Substring(5, 3) + word[8];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Исправленное слово: {result}");
    }
}