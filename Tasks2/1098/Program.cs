using System;
class Program
{
    static void Main()
    {
        string wordA = "прроцесор";
        string resultA = "";

        for (int i = 0; i < wordA.Length; i++)
        {
            if (i == 1 && wordA[i] == 'р' && wordA[i + 1] == 'р')
            {
                continue;
            }
            else if (i == 5 && wordA[i] == 'с')
            {
                resultA += wordA[i];
                resultA += 'с';
            }
            else
            {
                resultA += wordA[i];
            }
        }
        Console.WriteLine($"а) Исправлено: {resultA}");

        string wordB = "теекстовыйфайл";
        string resultB = "";

        for (int i = 0; i < wordB.Length; i++)
        {
            if (i == 1 && wordB[i] == 'е' && wordB[i + 1] == 'е')
            {
                continue;
            }
            else if (i == 7 && wordB[i] == 'й' && wordB[i + 1] == 'ф')
            {
                resultB += wordB[i];
                resultB += ' ';
            }
            else
            {
                resultB += wordB[i];
            }
        }
        Console.WriteLine($"б) Исправлено: {resultB}");

        string wordC = "програма и  аллгоритм";
        string resultC = "";

        for (int i = 0; i < wordC.Length; i++)
        {
            if (i == 4 && wordC[i] == 'а' && wordC[i + 1] == 'м')
            {
                resultC += 'м';
                resultC += wordC[i];
            }
            else if (i == 10 && wordC[i] == ' ' && wordC[i + 1] == ' ')
            {
                continue;
            }
            else if (i == 13 && wordC[i] == 'л' && wordC[i + 1] == 'л')
            {
                continue;
            }
            else if (i == 19 && wordC[i] == 'т' && wordC[i + 1] == 'м')
            {
                resultC += wordC[i];
                resultC += 'и';
            }
            else
            {
                resultC += wordC[i];
            }
        }
        Console.WriteLine($"в) Исправлено: {resultC}");

        string wordD = "процесор и  паммять";
        string resultD = "";

        for (int i = 0; i < wordD.Length; i++)
        {
            if (i == 4 && wordD[i] == 'с')
            {
                resultD += wordD[i];
                resultD += 'с';
            }
            else if (i == 10 && wordD[i] == ' ' && wordD[i + 1] == ' ')
            {
                continue;
            }
            else if (i == 13 && wordD[i] == 'м' && wordD[i + 1] == 'м')
            {
                continue;
            }
            else if (i == 18 && wordD[i] == 'т')
            {
                resultD += wordD[i];
                resultD += 'ь';
            }
            else
            {
                resultD += wordD[i];
            }
        }
        Console.WriteLine($"г) Исправлено: {resultD}");
    }
}