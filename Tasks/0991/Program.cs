using System;
class Program
{
    static void Main()
    {
        string word = "программа";

        string slovo1 = word.Substring(3, 3);
        string slovo2 = word.Substring(2, 1) + word.Substring(4, 4);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'ром': {slovo1}");
        Console.WriteLine($"Слово 'рампа': {slovo2}");
    }
}