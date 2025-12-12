using System;
class Program
{
    static void Main()
    {
        string word = "рпроцессо";

        string result = word[1].ToString() + word[0] + word.Substring(2, 6) + 'р';

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Исправленное слово: {result}");
    }
}