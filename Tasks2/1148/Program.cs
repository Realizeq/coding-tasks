using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        string foundWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 0 && (words[i][0] == 'к' || words[i][0] == 'К'))
            {
                foundWord = words[i];
                break;
            }
        }

        if (foundWord != "")
        {
            Console.WriteLine($"Слово, начинающееся на 'к': {foundWord}");
        }
        else
        {
            Console.WriteLine("Нет слов, начинающихся на 'к'");
        }
    }
}