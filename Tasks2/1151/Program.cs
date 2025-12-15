using System;
class Program
{
    static void Main()
    {
        Console.Write("Введите предложение: ");
        string predlozhenie = Console.ReadLine();

        string[] words = predlozhenie.Split(' ');

        string longestWord = "";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longestWord.Length)
            {
                longestWord = words[i];
            }
        }

        bool hasMoreThan10 = longestWord.Length > 10;

        Console.WriteLine($"Самое длинное слово: {longestWord}");
        Console.WriteLine($"Имеет больше 10 символов: {(hasMoreThan10 ? "да" : "нет")}");
    }
}