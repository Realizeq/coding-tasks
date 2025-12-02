using System;
class Program
{
    static void Main()
    {
        string word = "пробел";

        string result = word.Remove(3, 1).Insert(3, "д");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'продел': {result}");
    }
}