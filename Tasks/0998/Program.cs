using System;
class Program
{
    static void Main()
    {
        string word = "строка";

        string result = word + "ф";
        result = result.Remove(5, 1).Insert(5, "а");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'строфа': {result}");
    }
}