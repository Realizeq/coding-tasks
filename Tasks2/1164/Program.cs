using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите строку: ");
        string stroka = Console.ReadLine();

        Console.Write("Введите требуемую длину: ");
        int targetLength = int.Parse(Console.ReadLine());

        string[] words = stroka.Split(' ');
        int wordCount = words.Length;

        if (wordCount < 2)
        {
            Console.WriteLine("Строка должна содержать хотя бы 2 слова");
            return;
        }

        int currentLength = 0;
        foreach (string word in words)
        {
            currentLength += word.Length;
        }

        int spacesNeeded = targetLength - currentLength;
        int spacesBetweenWords = wordCount - 1;

        if (spacesNeeded < spacesBetweenWords)
        {
            Console.WriteLine("Требуемая длина слишком мала");
            return;
        }

        int baseSpaces = spacesNeeded / spacesBetweenWords;
        int extraSpaces = spacesNeeded % spacesBetweenWords;

        string result = "";

        for (int i = 0; i < wordCount; i++)
        {
            result += words[i];

            if (i < wordCount - 1)
            {
                int spacesToAdd = baseSpaces;
                if (i < extraSpaces)
                {
                    spacesToAdd++;
                }

                for (int j = 0; j < spacesToAdd; j++)
                {
                    result += " ";
                }
            }
        }

        Console.WriteLine($"Результат: {result}");
        Console.WriteLine($"Длина результата: {result.Length}");
    }
}