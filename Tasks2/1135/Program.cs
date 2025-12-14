using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        Console.Write("Результат: ");

        for (int i = 0; i < word1.Length; i++)
        {
            bool alreadyChecked = false;

            for (int j = 0; j < i; j++)
            {
                if (word1[i] == word1[j])
                {
                    alreadyChecked = true;
                    break;
                }
            }

            if (alreadyChecked)
            {
                continue;
            }

            bool found = false;
            for (int j = 0; j < word2.Length; j++)
            {
                if (word1[i] == word2[j])
                {
                    found = true;
                    break;
                }
            }

            if (found)
            {
                Console.Write("да ");
            }
            else
            {
                Console.Write("нет ");
            }
        }
    }
}