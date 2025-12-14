using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        int differentLetters = 0;

        for (char letter = 'а'; letter <= 'я'; letter++)
        {
            bool found = false;
            for (int i = 0; i < word.Length; i++)
            {
                if (char.ToLower(word[i]) == letter)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                differentLetters++;
            }
        }

        Console.WriteLine($"Количество различных букв в слове: {differentLetters}");
    }
}