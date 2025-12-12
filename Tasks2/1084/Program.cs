using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        string resultA = "";
        bool removedO = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (!removedO && (word[i] == 'о' || word[i] == 'О'))
            {
                removedO = true;
                continue;
            }
            resultA += word[i];
        }
        Console.WriteLine($"а) Удалена первая буква 'о': {resultA}");

        string resultB = "";
        int lastL = -1;

        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == 'л' || word[i] == 'Л')
            {
                lastL = i;
            }
        }

        for (int i = 0; i < word.Length; i++)
        {
            if (i != lastL)
            {
                resultB += word[i];
            }
        }
        Console.WriteLine($"б) Удалена последняя буква 'л': {resultB}");
    }
}