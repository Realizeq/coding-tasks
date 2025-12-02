using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 4)
        {
            string result = word.Substring(1, 3);
            Console.WriteLine($"Часть слова (2-4 символы): {result}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}