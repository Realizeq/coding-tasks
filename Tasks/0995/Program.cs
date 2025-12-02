using System;
class Program
{
    static void Main()
    {
        string word = "вирус";

        string result = "ф" + word.Substring(1, 4);
        result = result.Remove(2, 1).Insert(2, "к");
        result = result.Remove(3, 1).Insert(3, "у");

        Console.WriteLine($"Исходное слово: {word}");
        Console.WriteLine($"Новое слово 'фокус': {result}");
    }
}