using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        string duplicateWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    duplicateWord = words[i];
                    break;
                }
            }
            if (duplicateWord != "")
            {
                break;
            }
        }

        if (duplicateWord != "")
        {
            Console.WriteLine($"Два одинаковых слова: {duplicateWord}");
        }
        else
        {
            Console.WriteLine("Нет двух одинаковых слов");
        }
    }
}