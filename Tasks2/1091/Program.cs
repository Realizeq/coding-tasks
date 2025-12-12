using System;
class Program
{
    static void Main()
    {
        string textA = "АРГЕНТИНА МАНИТ НЕГРА";
        string textB = "ПОТ КАК ПОТОП";
        string textC = "А  РОЗА УПАЛА НА ЛАПУ АЗОРА";

        string processA = "";
        for (int i = 0; i < textA.Length; i++)
        {
            if (textA[i] != ' ')
            {
                processA += textA[i];
            }
        }

        string processB = "";
        for (int i = 0; i < textB.Length; i++)
        {
            if (textB[i] != ' ')
            {
                processB += textB[i];
            }
        }

        string processC = "";
        for (int i = 0; i < textC.Length; i++)
        {
            if (textC[i] != ' ')
            {
                processC += textC[i];
            }
        }

        bool palindromeA = true;
        for (int i = 0; i < processA.Length / 2; i++)
        {
            if (processA[i] != processA[processA.Length - 1 - i])
            {
                palindromeA = false;
                break;
            }
        }

        bool palindromeB = true;
        for (int i = 0; i < processB.Length / 2; i++)
        {
            if (processB[i] != processB[processB.Length - 1 - i])
            {
                palindromeB = false;
                break;
            }
        }

        bool palindromeC = true;
        for (int i = 0; i < processC.Length / 2; i++)
        {
            if (processC[i] != processC[processC.Length - 1 - i])
            {
                palindromeC = false;
                break;
            }
        }

        Console.WriteLine($"а) \"{textA}\" после удаления пробелов: {processA}");
        Console.WriteLine($"   Палиндром: {palindromeA}");

        Console.WriteLine($"б) \"{textB}\" после удаления пробелов: {processB}");
        Console.WriteLine($"   Палиндром: {palindromeB}");

        Console.WriteLine($"в) \"{textC}\" после удаления пробелов: {processC}");
        Console.WriteLine($"   Палиндром: {palindromeC}");
    }
}