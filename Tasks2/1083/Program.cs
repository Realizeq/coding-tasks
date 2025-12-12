using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        if (word.Length >= 3)
        {
            string resultA = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i != 2)
                {
                    resultA += word[i];
                }
            }
            Console.WriteLine($"а) Удалена третья буква: {resultA}");
        }
        else
        {
            Console.WriteLine("а) Слово слишком короткое");
        }

        Console.Write("Введите номер буквы k для удаления: ");
        int k = int.Parse(Console.ReadLine());

        if (k > 0 && k <= word.Length)
        {
            string resultB = "";
            for (int i = 0; i < word.Length; i++)
            {
                if (i != k - 1)
                {
                    resultB += word[i];
                }
            }
            Console.WriteLine($"б) Удалена {k}-я буква: {resultB}");
        }
        else
        {
            Console.WriteLine("б) Некорректный номер буквы");
        }
    }
}