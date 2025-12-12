using System;
class Program
{
    static void Main()
    {
        string word1 = "глинянный";
        string result1 = "";

        for (int i = 0; i < word1.Length; i++)
        {
            if (i == 5)
            {
                continue;
            }
            result1 += word1[i];
        }
        Console.WriteLine($"а) Исправленное слово: {result1}");

        string word2 = "граффика";
        string result2 = "";

        for (int i = 0; i < word2.Length; i++)
        {
            if (i == 4)
            {
                continue;
            }
            result2 += word2[i];
        }
        Console.WriteLine($"б) Исправленное слово: {result2}");
    }
}