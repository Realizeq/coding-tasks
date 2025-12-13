using System;
class Program
{
    static void Main()
    {
        string word = "килбайот";

        string result = word.Substring(0, 3) + 'о' + word.Substring(3, 2) + word[6] + word[7];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Исправленное слово: {result}");
    }
}