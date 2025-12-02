using System;
class Program
{
    static void Main()
    {
        string word = "курсор";

        string result = "т" + word.Substring(1, 5);
        result = result.Remove(1, 1).Insert(1, "а");
        result = result.Remove(2, 1).Insert(2, "н");
        result = result.Remove(3, 1).Insert(3, "ц");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'танцор': {result}");
    }
}