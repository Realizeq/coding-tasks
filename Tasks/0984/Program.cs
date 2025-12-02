using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 3)
        {
            char tretiy = word[2];
            char posledniy = word[word.Length - 1];
            string result = tretiy.ToString() + posledniy.ToString();
            Console.WriteLine($"Буквосочетание из третьего и последнего символов: {result}");
        }
        else
        {
            Console.WriteLine("Слово слишком короткое");
        }
    }
}