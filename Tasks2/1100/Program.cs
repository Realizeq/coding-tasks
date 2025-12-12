using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length > 1)
        {
            string result = word.Substring(1) + word[0];
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}