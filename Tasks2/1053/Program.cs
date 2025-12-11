using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        int count = 0;
        int minLength = Math.Min(word1.Length, word2.Length);

        for (int i = 0; i < minLength; i++)
        {
            if (word1[i] == word2[i])
            {
                count++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"Количество совпадающих начальных букв: {count}");

        if (word1 == word2)
        {
            Console.WriteLine("Слова одинаковые");
        }
        else
        {
            Console.WriteLine("Слова разные");
        }
    }
}