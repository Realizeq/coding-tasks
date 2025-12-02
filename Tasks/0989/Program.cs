using System;
class Program
{
    static void Main()
    {
        string word = "информатика";

        string slovo1 = word.Substring(2, 5);
        string slovo2 = word.Substring(7, 3);

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Слово 'форма': {slovo1}");
        Console.WriteLine($"Слово 'тик': {slovo2}");
    }
}