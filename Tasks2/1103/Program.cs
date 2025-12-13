using System;
class Program
{
    static void Main()
    {
        string word = "алигортм";

        string result = word[0].ToString() + word[4] + word.Substring(1, 3) + word[5] + word[6] + word[7];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Исправленное слово: {result}");
    }
}