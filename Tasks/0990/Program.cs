using System;
class Program
{
    static void Main()
    {
        string word = "вертикаль";

        string slovo1 = word[4].ToString() + word[2] + word[5];
        string slovo2 = word.Substring(0, 1) + word.Substring(2, 2) + word.Substring(5, 2);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'тир': {slovo1}");
        Console.WriteLine($"Слово 'ветка': {slovo2}");
    }
}