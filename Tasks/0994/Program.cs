using System;
class Program
{
    static void Main()
    {
        string word = "апельсин";

        string result = word[6].ToString() + word[0] + word[1] + word[4] + word[5] + word[7] + word[2] + word[3];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'спаниель': {result}");
    }
}