using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите первое слово: ");
        string word1 = Console.ReadLine();

        Console.Write("Введите второе слово: ");
        string word2 = Console.ReadLine();

        bool variant1 = true;

        for (int i = 0; i < word2.Length; i++)
        {
            bool found = false;
            for (int j = 0; j < word1.Length; j++)
            {
                if (word2[i] == word1[j])
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                variant1 = false;
                break;
            }
        }

        Console.WriteLine($"1) Можно ли получить второе слово из букв первого (без учета повторений): {(variant1 ? "да" : "нет")}");

        bool variant2 = true;

        for (char letter = 'а'; letter <= 'я'; letter++)
        {
            int countInWord1 = 0;
            int countInWord2 = 0;

            for (int i = 0; i < word1.Length; i++)
            {
                if (word1[i] == letter)
                {
                    countInWord1++;
                }
            }

            for (int i = 0; i < word2.Length; i++)
            {
                if (word2[i] == letter)
                {
                    countInWord2++;
                }
            }

            if (countInWord2 > countInWord1)
            {
                variant2 = false;
                break;
            }
        }

        Console.WriteLine($"2) Можно ли получить второе слово из букв первого (с учетом количества): {(variant2 ? "да" : "нет")}");
    }
}