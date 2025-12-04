using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово (длинное): ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово (короткое): ");
        string word2 = Console.ReadLine();

        if (word1.Length > word2.Length)
        {
            string result = word1.Substring(0, word2.Length) + word1.Substring(word2.Length);
            Console.WriteLine($"Результат: {result}");
        }
        else
        {
            Console.WriteLine("Первое слово должно быть длиннее второго");
        }
    }
}