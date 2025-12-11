using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        bool palindrome = true;

        for (int i = 0; i < word.Length / 2; i++)
        {
            if (word[i] != word[word.Length - 1 - i])
            {
                palindrome = false;
                break;
            }
        }

        if (palindrome)
        {
            Console.WriteLine($"Слово '{word}' является палиндромом");
        }
        else
        {
            Console.WriteLine($"Слово '{word}' не является палиндромом");
        }
    }
}