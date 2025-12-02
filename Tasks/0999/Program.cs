using System;
class Program
{
    static void Main()
    {
        string word = "муха";

        string result = "с" + word.Substring(1, 3);
        result = result.Remove(1, 1).Insert(1, "л");
        result = result.Remove(2, 1).Insert(2, "о");
        result = result.Remove(3, 1).Insert(3, "н");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'слон': {result}");
    }
}