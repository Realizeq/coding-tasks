using System;
class Program
{
    static void Main()
    {
        string word = "клоун";

        string slovo1 = word[4].ToString() + word[0] + word[1] + word[2] + word[3];
        string slovo2 = word[0].ToString() + word[4] + word[1] + word[2] + word[3];
        string slovo3 = word[0].ToString() + word[2] + word[1] + word[4] + word[3];

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'уклон': {slovo1}");
        Console.WriteLine($"Слово 'кулон': {slovo2}");
        Console.WriteLine($"Слово 'колун': {slovo3}");
    }
}