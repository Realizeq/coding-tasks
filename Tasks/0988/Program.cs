using System;
class Program
{
    static void Main()
    {
        string word = "яблоко";

        string slovo1 = word.Substring(1, 4);
        string slovo2 = word.Substring(3, 3);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'блок': {slovo1}");
        Console.WriteLine($"Слово 'око': {slovo2}");
    }
}