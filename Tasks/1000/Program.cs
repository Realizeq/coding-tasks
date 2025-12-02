using System;
class Program
{
    static void Main()
    {
        string word = "тетрадь";

        string result = "д" + word.Substring(1, 6);
        result = result.Remove(1, 1).Insert(1, "н");
        result = result.Remove(2, 1).Insert(2, "е");
        result = result.Remove(3, 1).Insert(3, "в");
        result = result.Remove(4, 1).Insert(4, "н");
        result = result.Remove(5, 1).Insert(5, "и");
        result = result.Remove(6, 1).Insert(6, "к");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'дневник': {result}");
    }
}