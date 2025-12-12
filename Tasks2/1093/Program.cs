using System;
class Program
{
    static void Main()
    {
        string phrase = "ценая вещь_";

        string result = "";
        bool inserted = false;

        for (int i = 0; i < phrase.Length; i++)
        {
            if (!inserted && i == 1)
            {
                result += 'н';
                result += phrase[i];
                inserted = true;
            }
            else
            {
                result += phrase[i];
            }
        }

        Console.WriteLine($"Исправленная фраза: {result}");
    }
}