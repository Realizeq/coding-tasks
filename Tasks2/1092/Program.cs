using System;
class Program
{
    static void Main()
    {
        string word = "стекляный_";

        string result = "";
        bool inserted = false;

        for (int i = 0; i < word.Length; i++)
        {
            if (!inserted && i == 6)
            {
                result += 'н';
                result += word[i];
                inserted = true;
            }
            else
            {
                result += word[i];
            }
        }

        Console.WriteLine($"Исправленное слово: {result}");
    }
}