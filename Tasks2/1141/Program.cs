using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Введите третье слово: ");
        string word3 = Console.ReadLine();

        string allLetters = word1 + word2 + word3;

        Console.Write("Неповторяющиеся буквы: ");

        for (int i = 0; i < allLetters.Length; i++)
        {
            int count = 0;

            for (int j = 0; j < allLetters.Length; j++)
            {
                if (allLetters[i] == allLetters[j])
                {
                    count++;
                }
            }

            if (count == 1)
            {
                Console.Write(allLetters[i] + " ");
            }
        }
    }
}