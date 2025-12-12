using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите слово: ");
        string word = Console.ReadLine();

        string result = "";

        for (int i = 0; i < word.Length; i++)
        {
            bool found = false;

            for (int j = 0; j < result.Length; j++)
            {
                if (word[i] == result[j])
                {
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                result += word[i];
            }
        }

        Console.WriteLine($"Результат: {result}");
    }
}