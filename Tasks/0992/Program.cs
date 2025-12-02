using System;
class Program
{
    static void Main()
    {
        string word = "трос";

        string slovo1 = word[2].ToString() + word[3] + word[0] + word[1];
        string slovo2 = word[0].ToString() + word[2] + word[1] + word[3];
        string slovo3 = word[1].ToString() + word[3] + word[0] + word[2];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'сорт': {slovo1}");
        Console.WriteLine($"Слово 'рост': {slovo2}");
        Console.WriteLine($"Слово 'торс': {slovo3}");
    }
}